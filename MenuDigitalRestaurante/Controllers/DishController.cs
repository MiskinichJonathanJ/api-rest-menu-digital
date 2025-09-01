using Application.DataTransfers.Request;
using Application.DataTransfers.Response;
using Application.Interfaces.DishInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Management.Compute.Fluent.Models;

namespace MenuDigitalRestaurante.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Produces("application/json")]
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
        /// /// <remarks>
        /// Validaciones:
        /// - El nombre del plato debe ser único
        /// - El precio debe ser mayor a 0
        /// - La categoría debe existir en el sistema
        ///
        /// Casos de uso:
        /// - Agregar nuevos platos al menú
        /// - Platos estacionales o especiales del chef
        /// </remarks> 
        /// <param name="request">Datos del plato a crear</param>
        /// <response code="201">Plato creado exitosamente</response>
        /// <response code="400">Datos de entradas invalidos</response>
        /// <response code="409">Ya existe un plato con el mismo nombre</response>
        [HttpPost]
        [ProducesResponseType(typeof(DishResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> CreateDish([FromBody] DishRequest request)
        {
            var result = await _services.CreateDish(request);
            return new JsonResult(result);
        }


        /// <summary>
        /// Buscar platos.
        /// </summary>
        /// <remarks>
        /// Obtiene una lista de platos del menú con opciones de filtrado y ordenamiento.
        /// Filtros disponibles:
        /// - Por nombre (búsqueda parcial)  
        /// - Por categoría  
        /// - Solo platos activos/todos  
        ///
        /// Ordenamiento:
        /// - Por precio ascendente o descendente  
        /// - Sin ordenamiento específico  
        ///
        /// Casos de uso:
        /// - Mostrar menú completo a los clientes  
        /// - Buscar platos específicos  
        /// - Filtrar por categorías (entrantes, principales, postres)  
        /// - Administración del menú (incluyendo platos inactivos)  
        /// </remarks>
        /// <param name="name">Buscar platos por nombre (Busqueda parcial)</param>
        /// <param name="category"> Filtrar platos por categoría </param>
        /// <param name="onlyActive"> true para solo platos activos, false para todos </param>
        /// <param name="sortByPrice"> Ordenar por precio</param>
        /// <response code="200">Lista de platos obtenida exitosamente</response>
        /// <response code="400">Parametros de busqueda invalidos</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<DishResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
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
        [ProducesResponseType(typeof(DishResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> UpdateDish(Guid id,[FromBody] DishRequest request)
        {
            var result = await _services.UpdateDish(id, request);
            return Ok(result);
        }
    }
}
