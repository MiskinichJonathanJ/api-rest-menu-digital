using Application.DataTransfers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DishInterfaces
{
    public interface IDishValidator
    {
        Task ValidateCreate(DishRequest request);
        Task ValidateUpdate(Guid idDish,  DishRequest request);
    }
}
