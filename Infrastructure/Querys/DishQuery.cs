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
        public async Task<ICollection<Dish>> GetAllDish()
        {
            return await _context.Dishes.Include(d  => d.CategoryNav).ToListAsync();
        }

        public async Task<Dish> GetDishById(Guid dishId)
        {
            return await _context.Dishes.FirstOrDefaultAsync(d=> d.ID == dishId);
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
