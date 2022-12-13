using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class OrderProduct
    {
        public int OrderProductsId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public short? Quantity { get; set; }
        public decimal? SalePrice { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
