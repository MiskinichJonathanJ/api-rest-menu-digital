using Application.DataTransfers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDishServices
    {
        Task<DishResponse> CreateDish(DishRequest request, int category);
        Task DeleteDish(int id);
        Task<ICollection<DishResponse>> GetAllDish();
        Task<Dish> GetDishById(int id);
        Task<DishResponse> UpdateDish(Guid id, DishRequest request);

    }
}
