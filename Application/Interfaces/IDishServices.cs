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
        Task<DishResponse> CreateDish(CreateDishRequest request, int category);
        Task DeleteDish(int id);
        Task<ICollection<DishResponse>> GetAllDish();
        Task<Dish> GetDishById(int id);
        Task UpdateDish(int id, Dish dish);

    }
}
