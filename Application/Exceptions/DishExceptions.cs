using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class DishNameAlreadyExistsException : Exception
    {
        public DishNameAlreadyExistsException(string message) : base(message) {}
    }

    public class DishNotFoundException : Exception
    {
        public  DishNotFoundException(string  message)  : base(message) { }
    }

    public class InvalidDishPriceException : Exception
    {
        public InvalidDishPriceException(string message) : base(message) { }
    }

    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException(string message) : base(message) { }
    }
}
