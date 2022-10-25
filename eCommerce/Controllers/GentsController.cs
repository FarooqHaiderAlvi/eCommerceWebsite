using eCommerce.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Controllers
{
    public class GentsController : Controller
    {
        private readonly ILogger<GentsController> _logger;
        private readonly menRepoDI repodi;
        public GentsController(ILogger<GentsController> _log, menRepoDI repoDI)
        {

            _logger = _log;
            repodi = repoDI;
            
        }
        public ViewResult gentsPage()
        {
            ViewBag.l = repodi.featureProducts();
            ViewBag.k = repodi.showProducts();
            return View();
        }
    }
}
