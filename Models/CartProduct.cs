using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class CartProduct
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }


    }
}
