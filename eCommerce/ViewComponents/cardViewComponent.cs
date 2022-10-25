using eCommerce.Models;
using eCommerce.Models.Interface;
using eCommerce.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.ViewComponents
{
    public class cardViewComponent:ViewComponent

    {
        public readonly userRepoDI repodi;
        public cardViewComponent(userRepoDI repodi)
        {
            this.repodi = repodi;
        }
        public IViewComponentResult Invoke()
        {
            user u = new user();
          u=repodi.getProfile();
            return View(u);
        }
    }
}
