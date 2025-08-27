using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Command
{
    public class DishCommand : IDishCommand
    {
        public readonly AppDbContext _context;

        public DishCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateDish(Dish dish)
        {
            _context.Add(dish);

            await _context.SaveChangesAsync();
        }

        public Task DeleteDish(int id)
        {
            throw new NotImplementedException();
        }
    }
}
