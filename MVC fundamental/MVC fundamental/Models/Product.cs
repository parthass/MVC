﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_fundamental.Models
{
    public class Product
    {
        private string name; 
        public int ProductId { get; set; }

        public string Name 
        { 
            get
            {
                return ProductId + " " + name;
            }
            set
            {
                name = value;
            }
        
        }

        public string Description { get; set; }

        public decimal price { get; set; }

        public string Category { get; set; }
    }
}