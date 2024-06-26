using Business.Services.SliderAggregate.Sliders.Queries;
using Core.Utilities.Identity;
using Entities.RequestModel.SliderAggregate.Sliders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class SliderQueryServiceController : ControllerBase
    {
        private readonly ISliderQueryService _sliderQueryService;
        public SliderQueryServiceController(ISliderQueryService sliderQueryService)
        {
            _sliderQueryService = sliderQueryService;
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getallslider")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetAllSlider()
        {
            var result = await _sliderQueryService.GetAllSlider();
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getslider")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetSlider([FromQuery] GetSliderReqModel request)
        {
            var result = await _sliderQueryService.GetSlider(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }
    }
}
