using Business.Services.ProductAggregate.ProductStocks.DtoQueries;
using Core.Utilities.Identity;
using Entities.RequestModel.ProductAggregate.ProductStocks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStockDtoQueryServiceController : ControllerBase
    {
        private readonly IProductStockDtoQueryService _productStockDtoQueryService;
        public ProductStockDtoQueryServiceController(IProductStockDtoQueryService productStockDtoQueryService)
        {
            _productStockDtoQueryService = productStockDtoQueryService;
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getallproductstockdto")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetAllProductStockDto([FromQuery] GetAllProductStockReqModel request)
        {
            var result = await _productStockDtoQueryService.GetAllProductStockDto(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }
    }
}
