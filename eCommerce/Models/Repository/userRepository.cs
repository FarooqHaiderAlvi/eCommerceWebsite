using eCommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
   
    public class userRepository:userRepoDI
    {
        public int id { get; set; }
      
        public void addUser(user u)
        {
            var db = new eCommerceContext();
            db.users.Add(u);
            db.SaveChangesAsync();
        }

       
       public user getProfile()
        {
            var db = new eCommerceContext();
            user u = new user();
            u = db.users.Where(e => e.id.Equals(id)).Select(e => e).FirstOrDefault();
            return u;
        }

        public bool checkCredential(user u)
        {
            var db = new eCommerceContext();

            
          var a=  db.users.Where(e => e.Username.Equals(u.Username) && e.Password.Equals(u.Password)).Select(e=>e).FirstOrDefault();
            if (a != null)
            {

                id = a.id;
                return true;
            }
            return false;
        }
    }
}
