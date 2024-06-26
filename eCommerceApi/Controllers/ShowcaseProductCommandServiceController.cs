using Business.Services.ShowcaseAggregate.ShowCaseProducts.Commands;
using Core.Utilities.Identity;
using Entities.RequestModel.ShowcaseAggregate.ShowCaseProducts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class ShowcaseProductCommandServiceController : ControllerBase
    {
        private readonly IShowcaseProductCommandService _showcaseProductCommandService;
        public ShowcaseProductCommandServiceController(IShowcaseProductCommandService showcaseProductCommandService)
        {
            _showcaseProductCommandService = showcaseProductCommandService;
        }

        [Produces("application/json", "text/plain")]
        [HttpPost("deleteshowcaseproduct")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> DeleteShowCaseProduct([FromBody] DeleteShowCaseProductReqModel request)
        {
            var result = await _showcaseProductCommandService.DeleteShowCaseProduct(request);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpPost("insertproductshowcase")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> InsertProductShowcase([FromBody] InsertProductShowcaseReqModel showCaseProduct)
        {
            var result = await _showcaseProductCommandService.InsertProductShowcase(showCaseProduct);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
