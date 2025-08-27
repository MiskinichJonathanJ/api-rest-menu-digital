using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class DishQuery : IDishQuery
    {
        public readonly AppDbContext _context;

        public DishQuery(AppDbContext context)
        {
            _context = context;
        }
        public Task<ICollection<Dish>> GetAllDish()
        {
            throw new NotImplementedException();
        }

        public Task<Dish> GetDishById(int dishId)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            return   _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
