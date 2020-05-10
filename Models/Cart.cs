using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class Cart
    {
        public List<CartProduct> Items { get; set; } = new List<CartProduct>();
        
        public decimal Total
        {
            get
            {
                decimal total = (decimal)0.0;
                foreach(var item in Items)
                {
                    total += item.Product.Price;
                }
                return total;
            }
        }

        public DateTime LastAccessed { get; set; }
        public int TimeToLive { get; set; } = 30;
    }
}
