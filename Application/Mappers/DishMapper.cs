using Application.DataTransfers;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class DishMapper : IDishMapper
    {
        public Dish ToEntity(CreateDishRequest request)
        {
            var dish = new Dish
            {
                Name = request.DishName,
                Description = request.DishDescription,
                Price = request.DishPrice,
                IsAvailable = request.DishIsAvailable,
                CategoryNav = new Category
                {
                    Name = request.CategoryName,
                    Description = request.CategoryDescription,
                    Order = request.CategoryOrder
                }
            };

            return dish;
        }

        public DishResponse ToResponse(Dish dish)
        {
            var dishResponse = new DishResponse
            {
                DishName = dish.Name,
                DishDescription = dish.Description,
                DishPrice = dish.Price,
                DishIsAvailable = dish.IsAvailable,
                DishCategory = new CategoryResponse
                {
                    CategoryDescription = dish.CategoryNav.Description,
                    CategoryName = dish.CategoryNav.Name,
                    CategoryOrder = dish.CategoryNav.Order
                }
            };

            return dishResponse;
        }
    }
}
