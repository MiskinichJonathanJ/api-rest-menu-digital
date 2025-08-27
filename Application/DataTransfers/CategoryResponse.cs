using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfers
{
    public class CategoryResponse
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CategoryOrder { get; set; }
    }
}
