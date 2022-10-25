 //using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;
using eCommerce.Models.Interface;
namespace eCommerce.Controllers
{
    
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;
        private readonly userRepoDI repodi;
        private readonly homeRepoDI homerepodi;


        private readonly IWebHostEnvironment Environment;

        public HomeController(ILogger<HomeController> _log,homeRepoDI hrepodi, userRepoDI repoDI, IWebHostEnvironment environment)
        {

            _logger = _log ;
            repodi = repoDI;
            Environment = environment;
             homerepodi=hrepodi;
        }
    

        [HttpGet]
        public ViewResult signPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signPage(user u,List<IFormFile> i)
        {
            if (ModelState.IsValid)
            {
                string wwwpth = this.Environment.WebRootPath;
                string path = Path.Combine(wwwpth, "Uploads");

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


                    u.imgPath = filename;




                    repodi.addUser(u);

                    
                }

                //return RedirectToAction("loginPage", "Home");
                return RedirectToAction("loginPage", "Home", u);
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
        public IActionResult loginPage(user u)
        {
           if(repodi.checkCredential(u))
            {
                return RedirectToAction("homePage", "Home");
            }
            else
            {
                ViewBag.wrong = "Invalid Username Password";
                return View();
            }
        }
        public IActionResult homePage()
        {


           ViewBag.l= homerepodi.sliderImages();
            ViewBag.k = homerepodi.homeImages();
            return View();
        }
        public IActionResult showProduct(int id)
        {
            ViewBag.s = homerepodi.show(id);
            return View();
        }
    }
}
