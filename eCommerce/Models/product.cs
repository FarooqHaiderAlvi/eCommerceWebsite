using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class product
    {
        [Key]  
        public int id { get; set; }

        [Required(ErrorMessage ="Field required")]
        [StringLength(20)]
        public string name { get; set; }

        [Required(ErrorMessage = "Field required")]
        [StringLength(100)]
        public string description { get; set; }

        [Required(ErrorMessage = "Field required")]
        [Range(0.5,9999,ErrorMessage ="Price must be +ve and <=9999")]
        public float price { get; set; }

        public string imgPath { get; set; }
    }
}
