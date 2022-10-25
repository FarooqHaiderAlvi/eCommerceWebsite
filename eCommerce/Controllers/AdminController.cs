using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;
using Microsoft.Extensions.Logging;
using eCommerce.Models.Interface;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace eCommerce.Controllers
{
    public class AdminController : Controller

    {
        private readonly ILogger<AdminController> _logger;
        private readonly adminRepoDI repodi;


        private readonly IWebHostEnvironment Environment;

        public AdminController(ILogger<AdminController> _log, adminRepoDI repoDI, IWebHostEnvironment environment)
        {

            _logger = _log;
            repodi = repoDI;
            Environment = environment;   

        }
        [HttpGet]
        public ViewResult signPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signPage(admin a)
        {
            if (ModelState.IsValid)
            {
                repodi.addAdmin(a);    
                return RedirectToAction("loginPage", "Admin");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public IActionResult loginPage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult loginPage(admin a)
        {
            if (repodi.checkCredential(a))
            {
                return RedirectToAction("adminHome", "Admin");
            }
            else
            {
                ViewBag.wrong = "Invalid Username Password";
                return View();
            }
        }
        [HttpGet]
        public IActionResult adminHome()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult adminHome(product p, List<IFormFile> i)
        {
            if (ModelState.IsValid)
            {
                string wwwpth = this.Environment.WebRootPath;
                string path = Path.Combine(wwwpth, "productImages");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                foreach (var file in i)
                {
                    var filename = Path.GetFileNameWithoutExtension(file.FileName);
                    var extension = Path.GetExtension(file.FileName);
                    filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                    var pathewithfile = Path.Combine(path, filename);
                    using (FileStream stream = new FileStream(pathewithfile, FileMode.Create))
                    {

                        file.CopyTo(stream);
                        ViewBag.message = "File Uploaded";
                    }

                     
                    p.imgPath = filename;
                }
                repodi.addProducts(p);
                return View();
            }
            else
            {
                return View();
            
             }
        
         }
        [HttpGet]                 
        public IActionResult viewWomenProducts()
        {
           
            return View();
        }
        [HttpGet]                 
        public IActionResult viewmenProducts()
        {
           
            return View();
        } 
        [HttpGet]                 
        public IActionResult viewWatchProducts()
        {
           
            return View();
        }
        [HttpGet]                 
        public IActionResult viewAllProducts()
        {
            ViewBag.k=repodi.allProducts();
            return View();
        }
        
        [HttpGet]                 
        public IActionResult viewAllUsers()
        {
            ViewBag.k=repodi.allUsers();
            return View();
        }
        public IActionResult deleteProduct(int id)
        {
            repodi.deleteProduct(id);
            return RedirectToAction("viewAllProducts", "Admin");
        }
        public IActionResult deleteUser(int id)
        {
            repodi.deleteUser(id);
            return RedirectToAction("viewAllUsers", "Admin");
        }

        
        public IActionResult updateUser(int id)
        {
           user u= repodi.searchUser(id);
            return View("updateUser",u);
        }

      
    }
}                                   
