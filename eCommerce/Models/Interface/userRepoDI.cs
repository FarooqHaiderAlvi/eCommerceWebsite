using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;
namespace eCommerce.Models.Interface
{
    public interface userRepoDI
    {
       public void addUser(user u);
        //public void getID(user u);
        //public user getUser();
        public bool checkCredential(user u);
        public  user getProfile();
    }

}
