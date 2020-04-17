using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blazor.Models
{
    public class Product
    {
        public string id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Average_rating { get; set;}
        public ReviewModel[] reviews { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public string image_src { get; set; }
    }
}
