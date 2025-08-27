using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfers
{
    public class DishResponse
    {
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public decimal DishPrice { get; set; }
        public bool DishIsAvailable { get; set; }
        public CategoryResponse DishCategory { get; set; }

    }
}
