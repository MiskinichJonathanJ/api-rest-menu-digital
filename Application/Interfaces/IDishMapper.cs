using Application.DataTransfers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDishMapper
    {
        Dish ToEntity(CreateDishRequest request, Category category);
        DishResponse ToResponse(Dish dish);
    }
}
