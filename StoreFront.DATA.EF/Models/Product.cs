﻿using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public int CategoryId { get; set; }
        public decimal ProductPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantityOnOrder { get; set; }
        public bool IsDiscontinued { get; set; }
        public string? ProductImage { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
