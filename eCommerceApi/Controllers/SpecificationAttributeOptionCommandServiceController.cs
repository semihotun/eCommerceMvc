using Business.Services.SpeficationAggregate.SpecificationAttributeOptions.Commands;
using Core.Utilities.Identity;
using Entities.RequestModel.SpeficationAggregate.SpecificationAttributeOptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class SpecificationAttributeOptionCommandServiceController : ControllerBase
    {
        private readonly ISpecificationAttributeOptionCommandService _specificationAttributeOptionCommandService;
        public SpecificationAttributeOptionCommandServiceController(ISpecificationAttributeOptionCommandService specificationAttributeOptionCommandService)
        {
            _specificationAttributeOptionCommandService = specificationAttributeOptionCommandService;
        }

        [Produces("application/json", "text/plain")]
        [HttpPost("deletespecificationattributeoption")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> DeleteSpecificationAttributeOption([FromBody] DeleteSpecificationAttributeOptionReqModel specificationAttributeOption)
        {
            var result = await _specificationAttributeOptionCommandService.DeleteSpecificationAttributeOption(specificationAttributeOption);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpPost("insertspecificationattributeoption")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> InsertSpecificationAttributeOption([FromBody] InsertSpecificationAttributeOptionReqModel specificationAttributeOption)
        {
            var result = await _specificationAttributeOptionCommandService.InsertSpecificationAttributeOption(specificationAttributeOption);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpPost("updatespecificationattributeoption")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> UpdateSpecificationAttributeOption([FromBody] UpdateSpecificationAttributeOptionReqModel specificationAttributeOption)
        {
            var result = await _specificationAttributeOptionCommandService.UpdateSpecificationAttributeOption(specificationAttributeOption);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
