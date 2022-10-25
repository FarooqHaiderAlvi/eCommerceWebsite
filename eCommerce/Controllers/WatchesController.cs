using eCommerce.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Controllers
{
    public class WatchesController : Controller
    {
        private readonly ILogger<WatchesController> _logger;
        private readonly watchRepoDI repodi;




        public WatchesController(ILogger<WatchesController> _log, watchRepoDI repoDI)
        {
            _logger = _log;
            repodi = repoDI;
        }
        public ViewResult watchesPage()
        {
            ViewBag.l = repodi.featureProducts();
            ViewBag.k = repodi.showProducts();
            return View();               
        }

       
    }
}
