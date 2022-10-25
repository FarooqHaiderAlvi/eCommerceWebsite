using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class order
    {
        

        [Key]
        public int id { get; set; }

        public virtual user u { get; set; }
       
    }

}
