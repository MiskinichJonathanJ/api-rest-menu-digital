using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class DishQuery : IDishQuery
    {
        public Task<ICollection<Dish>> GetAllDish()
        {
            throw new NotImplementedException();
        }

        public Task<Dish> GetDishById(int dishId)
        {
            throw new NotImplementedException();
        }
    }
}
