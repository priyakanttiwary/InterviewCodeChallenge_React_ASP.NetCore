using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewCodeChallenge_React.Models
{

    public class ProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
