 using System;
using System.Collections.Generic;
using System.Text;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using Business.Services.ShowcaseAggregate.ShowcaseTypes;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Core.Utilities.Identity;
using Business.Services.ShowcaseAggregate.ShowcaseTypes.ShowcaseTypeServiceModel; 
 namespace eCommerce.Areas.Api { 
 [AuthorizeControl] 
 [Route("api/[controller]")] 
 [ApiController] 
 public class ShowcaseTypeServiceController : ControllerBase{ 
 private readonly IShowcaseTypeService _showcaseTypeService; 
 
 public ShowcaseTypeServiceController(IShowcaseTypeService showcaseTypeService){ 
 _showcaseTypeService=showcaseTypeService; 
 } 
 
 
 [Produces("application/json", "text/plain")] 
 [HttpGet("getallshowcasetype")] 
 [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))] 
 public async Task<IActionResult> GetAllShowCaseType () { 
 
 var result = await _showcaseTypeService.GetAllShowCaseType(); 
 
 if(result.Success) 
 return Ok(result.Data); 
 else 
 return BadRequest(result.Message); 
 } 
 
 
 [Produces("application/json", "text/plain")] 
 [HttpGet("getallshowcasetypeselectlistitem")] 
 [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))] 
 public async Task<IActionResult> GetAllShowCaseTypeSelectListItem ([FromQuery]GetAllShowCaseTypeSelectListItem request) { 
 
 var result = await _showcaseTypeService.GetAllShowCaseTypeSelectListItem(request); 
 
 if(result.Success) 
 return Ok(result.Data); 
 else 
 return BadRequest(result.Message); 
 } 
 
 } 
 }