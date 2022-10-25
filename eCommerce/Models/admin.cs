using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class admin
    {
        [Required(ErrorMessage = "field required")]
        [StringLength(30)]
        public string Username { get; set; }

        [DataType(DataType.Password)]

        [Required(ErrorMessage = "field required")]
        [StringLength(30)]
        public string Password { get; set; }

        [Key]
        public int id { get; set; }

       
    }
}
