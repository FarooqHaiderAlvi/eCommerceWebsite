using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models.Interface
{
    public interface homeRepoDI
    {
        public List<product> sliderImages();
        public List<product> homeImages();
        public product show(int id);
    }
}
