using Business.Services.BrandAggregate.Brands.Queries;
using Core.Utilities.Identity;
using Entities.RequestModel.BrandAggregate.Brands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class BrandQueryServiceController : ControllerBase
    {
        private readonly IBrandQueryService _brandQueryService;
        public BrandQueryServiceController(IBrandQueryService brandQueryService)
        {
            _brandQueryService = brandQueryService;
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getbrandlist")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetBrandList([FromQuery] GetBrandListReqModel request)
        {
            var result = await _brandQueryService.GetBrandList(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getbrand")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetBrand([FromQuery] GetBrandReqModel request)
        {
            var result = await _brandQueryService.GetBrand(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getbranddropdown")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetBrandDropdown([FromQuery] GetBrandDropdownReqModel request)
        {
            var result = await _brandQueryService.GetBrandDropdown(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }
    }
}
