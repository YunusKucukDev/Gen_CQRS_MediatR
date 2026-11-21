//#region ManuelCqrs
//using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Request;
//using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Response;
//using Gen_Cqrs_API_Project.ManuelCQRS.Handlers.CommandHandlers;
//using Gen_Cqrs_API_Project.ManuelCQRS.Handlers.QueryHandler;
//using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Request;
//using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Response;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Gen_Cqrs_API_Project.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        private readonly CreateProductCommandHandler _createProductCommandHandler;
//        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
//        private readonly GetByIdProductQueryHandler _getByIdProductQueryHandler;
//        private readonly GetAllProductQueryHandler _getAllProductQueryHandler;

//        public ProductController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetByIdProductQueryHandler getByIdProductQueryHandler, GetAllProductQueryHandler getAllProductQueryHandler)
//        {
//            _createProductCommandHandler = createProductCommandHandler;
//            _deleteProductCommandHandler = deleteProductCommandHandler;
//            _getByIdProductQueryHandler = getByIdProductQueryHandler;
//            _getAllProductQueryHandler = getAllProductQueryHandler;
//        }

//        [HttpGet]
//        public IActionResult GetAllProducts()
//        {
//            var products = _getAllProductQueryHandler.GetAllProduct();
//            return Ok(products);
//        }

//        [HttpGet("{id:guid}")]
//        [ProducesResponseType(typeof(GetByIdProductQueryResponse), StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public IActionResult GetProductById([FromRoute] Guid id)
//        {
//            var request = new GetByIdProductQueryRequest(id);
//            var product = _getByIdProductQueryHandler.GetByIdProduct(request);

//            if (product is null)
//            {
//                return NotFound();
//            }

//            return Ok(product);
//        }

//        [HttpPost]
//        [ProducesResponseType(typeof(CreateProductCommandResponse), StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public IActionResult CreateProduct([FromBody] CreateProductCommandRequest request)
//        {
//            var response = _createProductCommandHandler.CreateProduct(request);

//            if (!response.IsSuccess)
//            {
//                return BadRequest(response);
//            }

//            return Ok(response);
//        }

//        [HttpDelete("{ProductId}")]
//        public IActionResult DeleteProduct(DeleteProductCommandRequest request)
//        {
//            _deleteProductCommandHandler.DeleteProduct(request);
//            return Ok();
//        }
//    }
//}
//#endregion

#region MediatrCqrs
using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Request;
using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
        => Ok(await _mediator.Send(new GetAllProductQueryRequest()));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetProductById(GetByIdProductQueryRequest request)
        => Ok(await _mediator.Send(request));

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommandRequest request)
        => Ok(await _mediator.Send(request));

    [HttpDelete("{ProductId}")]
    public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        => Ok(await _mediator.Send(request));
}
#endregion


