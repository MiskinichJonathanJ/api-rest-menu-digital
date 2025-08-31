using Application.DataTransfers.Response;
using Application.DataTransfers.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.DishInterfaces;

namespace Application.Mappers
{
    public class DishMapper : IDishMapper
    {
        public Dish ToEntity(DishRequest request)
        {
            var dish = new Dish
            {
                Name = request.DishName,
                Description = request.DishDescription,
                Price = request.DishPrice,
                IsAvailable = true,
                ImageURL = request.ImageUrl,
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };
            return dish;
        }

        public DishResponse ToResponse(Dish dish)
        {
            var dishResponse = new DishResponse
            {
                ID = dish.ID,
                DishName = dish.Name,
                DishDescription = dish.Description,
                DishPrice = dish.Price,
                DishIsAvailable = dish.IsAvailable,
                DishImageURL = dish.ImageURL,
                DishCreatedDate = dish.CreatedDate,
                DishUpdatedDate = dish.UpdatedDate,
                category = new CategoryResponse
                {
                    CategoryId = dish.CategoryNav.Id,
                    CategoryName = dish.CategoryNav.Name
                }
            };

            return dishResponse;
        }
    }
}
