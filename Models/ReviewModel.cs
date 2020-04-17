using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class ReviewModel
    {
        public string id { get; set; }
        public string author_name { get; set; }
        public string title { get; set; }
        public DateTime timestamp { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
    }
}
