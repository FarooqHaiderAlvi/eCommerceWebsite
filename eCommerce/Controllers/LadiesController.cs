
using eCommerce.Models;
using eCommerce.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Controllers
{
    public class LadiesController : Controller
    {
        private readonly ILogger<LadiesController> _logger;
        private readonly womenRepoDI repodi;

        public LadiesController(ILogger<LadiesController> _log, womenRepoDI repoDI)
        {

            _logger = _log;
            repodi = repoDI;
          

        }
        public ViewResult ladiesPage()
        {
            ViewBag.l = repodi.featureProducts();
            ViewBag.k  = repodi.showProducts();
            return View();

        }
    }                                  
}
