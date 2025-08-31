using Application.DataTransfers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface IDishValidator
    {
        void ValidateCreate(DishRequest request);
        void ValidateUpdate();
    }
}
