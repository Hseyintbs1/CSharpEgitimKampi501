﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Dtos
{
    public class ResultProductDto
    {
        //sqlden  gelen tablomuzun proportylerini tutacağımız class
        
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductStock { get; set; }
        public string ProductPrice { get; set; }
        public string ProductCategory { get; set; }

    }
}
