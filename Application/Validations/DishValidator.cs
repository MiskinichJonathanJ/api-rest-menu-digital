using Application.DataTransfers.Request;
using Application.Interfaces.DishInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    public class DishValidator : IDishValidator
    {
        private readonly IDishQuery _query;

        public DishValidator(IDishQuery query)
        {
            _query = query;
        }

        public async Task ValidateCreate(DishRequest request)
        {
            var category = await _query.GetCategoryById(request.CategoryId);
            if (category == null)
                throw new Exception("La categoria no existe");

            var dishConNombre = await _query.GetAllDish(name: request.DishName);
            if (!dishConNombre.Any())
                throw new Exception("Ya existe un platillo con ese nombre");

            if (request.DishPrice <= 0)
                throw new Exception("El precio del platillo debe ser mayor a 0");
        }

        public async Task ValidateUpdate(Guid idDish, DishRequest request)
        {
            if(_query.GetDishById(idDish) == null)
                throw new Exception("El platillo no existe");
            await  ValidateCreate(request);
        }
    }
}
