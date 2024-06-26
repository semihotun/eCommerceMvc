using Business.Services.CategoriesAggregate.Categories.Queries;
using Core.Utilities.Identity;
using Entities.RequestModel.CategoriesAggregate.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerce.Areas.Api
{
    [AuthorizeControl]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryQueryServiceController : ControllerBase
    {
        private readonly ICategoryQueryService _categoryQueryService;
        public CategoryQueryServiceController(ICategoryQueryService categoryQueryService)
        {
            _categoryQueryService = categoryQueryService;
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getallcategories")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryQueryService.GetAllCategories();
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getallcategoriesbyparentcategoryid")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetAllCategoriesByParentCategoryId([FromQuery] GetAllCategoriesByParentCategoryIdReqModel request)
        {
            var result = await _categoryQueryService.GetAllCategoriesByParentCategoryId(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getcategorybyid")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdReqModel request)
        {
            var result = await _categoryQueryService.GetCategoryById(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [Produces("application/json", "text/plain")]
        [HttpGet("getcategorydropdown")]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> GetCategoryDropdown([FromQuery] GetCategoryDropdownReqModel request)
        {
            var result = await _categoryQueryService.GetCategoryDropdown(request);
            if (result.Success)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }
    }
}
