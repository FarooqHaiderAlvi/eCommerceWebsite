﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Models;
namespace eCommerce.Models.Interface
{
    public interface menRepoDI
    {
        public List<product> showProducts();
        public List<product> featureProducts();
    }
}
