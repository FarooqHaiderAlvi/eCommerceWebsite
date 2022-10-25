using eCommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models.Repository
{
    public class womenRepository:womenRepoDI
    {
        public List<product> showProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e => e.imgPath.StartsWith("lc")).Select(e => e).ToList();
            return l;
        }
        public List<product> featureProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e => e.imgPath.StartsWith("lf")).Select(e => e).ToList();
            return l;
        }
    }
}
