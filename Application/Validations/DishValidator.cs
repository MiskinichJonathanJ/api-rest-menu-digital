using Application.DataTransfers.Request;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validations
{
    internal class DishValidator : IDishValidator
    {
        private readonly IDishQuery _query;

        public DishValidator(IDishQuery query)
        {
            _query = query;
        }

        public async void ValidateCreate(DishRequest request)
        {
            var category = await _query.GetCategoryById(request.CategoryId);
            if (category == null)
                throw new Exception("La categoria no existe");
        }

        public void ValidateUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
