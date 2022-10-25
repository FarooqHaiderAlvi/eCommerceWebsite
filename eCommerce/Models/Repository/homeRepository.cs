using eCommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models.Repository
{
    public class homeRepository:homeRepoDI
    {
        public List<product> sliderImages()
        {
            var db = new eCommerceContext();
            List<product> l = new List<product>();
            l = db.products.Where(e => e.imgPath.StartsWith("hs")).Select(e => e).ToList();
            return l;
        }
        public List<product> homeImages()
        {
            var db = new eCommerceContext();
            List<product> l = new List<product>();
            l = db.products.Where(e => e.imgPath.StartsWith("hi")).Select(e => e).ToList();
            return l;
        }
        public product show(int id)
        {
            var db = new eCommerceContext();
            product l = new product();
            l = db.products.Where(e => e.id.Equals(id)).Select(e => e).FirstOrDefault();
            return l;
        }
    }
}
