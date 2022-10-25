using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace eCommerce.Models
{
    public class user
    {
        [Required(ErrorMessage ="field required")]
        [StringLength(30)] 
        public string Username { get; set; }

        [DataType(DataType.Password)]
       
        [Required(ErrorMessage = "field required")]
        [StringLength(30)]
        public string Password { get; set; }

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "field required")]
        [StringLength(30)]
        
        [DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }
        public string imgPath { get; set; }
       
         public virtual List<order> l { get; set; }

    }
}
