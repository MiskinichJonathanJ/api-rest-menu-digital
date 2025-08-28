using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfers
{
    public class DishResponse
    {
        public int ID { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public decimal DishPrice { get; set; }
        public bool DishIsAvailable { get; set; }
        public string DishImageURL { get; set; }
        public CategoryResponse category { get; set; }
        public DateTime DishCreatedDate { get; set; }
        public DateTime DishUpdatedDate { get; set; }

    }
}
