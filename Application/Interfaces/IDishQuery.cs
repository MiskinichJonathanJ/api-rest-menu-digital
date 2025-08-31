using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDishQuery
    {
        Task<ICollection<Dish>> GetAllDish(
            string? name = null,
            int? categoryId = null,
            bool onlyActive = true,
            string? sortByPrice = null
        );
        Task<Dish?> GetDishById(Guid dishId);
        Task<Category?> GetCategoryById(int id);
    }
}
