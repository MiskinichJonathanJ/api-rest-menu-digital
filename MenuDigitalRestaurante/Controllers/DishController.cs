using Application.DataTransfers.Request;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuDigitalRestaurante.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        public readonly IDishServices _services;

        public DishController(IDishServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Crear un nuevo plato.
        /// </summary>
        /// <param name="request">Datos del plato crear</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateDish(DishRequest request)
        {
            var result = await _services.CreateDish(request, request.CategoryId);
            return new JsonResult(result);
        }

        [HttpGet]
        public  async Task<IActionResult>  GetAll(
            [FromQuery] string? name,
            [FromQuery] int? category,
            [FromQuery] bool onlyActive = true,
            [FromQuery] string? sortByPrice = null
        )
        {
            var result = await _services.GetAllDish(name, category, onlyActive, sortByPrice);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDish(Guid id, DishRequest request)
        {
            var result = await _services.UpdateDish(id, request);
            return Ok(result);
        }

    }
}
