﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopShoes.Domain.Request
{
    public class SaveProductReq
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
    }
}
