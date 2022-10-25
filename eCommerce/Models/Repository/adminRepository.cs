using eCommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models.Repository
{
    public class adminRepository:adminRepoDI
    { 
        public void addAdmin(admin a)      
        {
            var db = new eCommerceContext();
            db.admins.Add(a);
            db.SaveChangesAsync();
        }
        public bool checkCredential(admin a)
        {
            var db = new eCommerceContext();


            var u = db.admins.Where(e => e.Username.Equals(a.Username) && e.Password.Equals(a.Password)).Select(e => e).FirstOrDefault();
            if (u != null)
            {

                return true;
            }
            return false;
        }
        public void addProducts(product w)
        {
            var db = new eCommerceContext();  
            db.products.Add(w);
            db.SaveChangesAsync();

        }

        public List<product> womenProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e=>e.imgPath.StartsWith("lc")).Select(e => e).ToList();
            return l;
        }
        public List<product> menProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e=>e.imgPath.StartsWith("mc")).Select(e => e).ToList();
            return l;
        } 
        public List<product> watchProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e=>e.imgPath.StartsWith("wc")).Select(e => e).ToList();
            return l;
        }
        public List<product> allProducts()
        {
            List<product> l = new List<product>();
            var db = new eCommerceContext();

            l = db.products.Where(e=>e.imgPath.StartsWith("lc") || e.imgPath.StartsWith("wc")|| e.imgPath.StartsWith("mc")).Select(e => e).ToList();
            return l;
        }

        public List<user> allUsers()
        {
            List<user> l = new List<user>();
            var db = new eCommerceContext();
            l = db.users.Select(e => e).ToList();
            return l;
        }
        public void deleteProduct(int id)
        {
            var db = new eCommerceContext();
            product p = new product();
            p = db.products.Where(e => e.id.Equals(id)).Select(e => e).FirstOrDefault();
            db.products.Remove(p);
            db.SaveChangesAsync();
        }
        public void deleteUser(int id)
        {
            var db = new eCommerceContext();
            user p = new user();
            p = db.users.Where(e => e.id.Equals(id)).Select(e => e).FirstOrDefault();
            db.users.Remove(p);
            db.SaveChangesAsync();
        }
        public user searchUser(int id)
        {
            var db = new eCommerceContext();
            user p = new user();
            p = db.users.Where(e => e.id.Equals(id)).Select(e => e).FirstOrDefault();
            return p;
        }
    }
}
