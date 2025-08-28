using Application.DataTransfers;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Application.UseCase.DishUse
{
    public class DishServices : IDishServices
    {
        public readonly IDishCommand _command;
        public readonly IDishQuery _query;
        public readonly IDishMapper _mapper;

        public DishServices(IDishCommand command, IDishQuery query, IDishMapper mapper)
        {
            _command = command;
            _query = query;
            _mapper = mapper;
        }

        public async Task<DishResponse> CreateDish(DishRequest request, int  id)
        {
            var category = _query.GetCategoryById(id);
            var dish = _mapper.ToEntity(request, category);
            await _command.CreateDish(dish);
            return _mapper.ToResponse(dish);
        } 

        public Task DeleteDish(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<DishResponse>> GetAllDish()
        {
            var  result = await _query.GetAllDish();
            return result.Select(d => _mapper.ToResponse(d)).ToList();
        }

        public Task<Dish> GetDishById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDish(int id, Dish dish)
        {
            throw new NotImplementedException();
        }
    }
}
