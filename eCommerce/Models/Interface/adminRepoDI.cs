using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;
namespace eCommerce.Models.Interface
{
    public interface adminRepoDI
    {
        public void addAdmin(admin u);
      
        public bool checkCredential(admin u);

        public void addProducts(product w);

        public List<product> womenProducts();
        public List<product> watchProducts();
        public List<product> menProducts();
        public List<product> allProducts();
        public List<user> allUsers();
        public void deleteProduct(int id);
        public void deleteUser(int id);
        public user searchUser(int id);



    }
}
