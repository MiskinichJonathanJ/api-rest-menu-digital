using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfers.Request
{
    public class DishRequest
    {
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public decimal DishPrice { get; set; }
        public int CategoryId { get; set;  }
        public string ImageUrl { get; set; }
    }
}
