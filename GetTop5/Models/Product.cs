﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetTop5.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateAdded { get; set; }
    }
}