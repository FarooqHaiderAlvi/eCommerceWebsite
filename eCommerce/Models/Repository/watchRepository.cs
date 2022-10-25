using eCommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models.Repository
{
    public class watchRepository:watchRepoDI
    {
        public List<product> showProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e => e.imgPath.StartsWith("wc")).Select(e => e).ToList();
            return l;
        }
        public List<product> featureProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e => e.imgPath.StartsWith("wf")).Select(e => e).ToList();
            return l;
        }
    }
}
