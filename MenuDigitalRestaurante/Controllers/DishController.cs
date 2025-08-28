using Application.DataTransfers;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuDigitalRestaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        public readonly IDishServices _services;

        public DishController(IDishServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDish(CreateDishRequest request)
        {
            var result = await _services.CreateDish(request, request.CategoryId);
            return new JsonResult(result);
        }

        [HttpGet]
        public  async Task<IActionResult>  GetAll()
        {
            var result = await _services.GetAllDish();
            return Ok(result);
        }

    }
}
