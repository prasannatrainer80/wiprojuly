using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestEmployCrud.Services;
using RestEmployCrud.Models;

namespace RestEmployCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestEmployController : ControllerBase
    {
        private readonly IApiService _apiService; 

        public RestEmployController(IApiService apiService)
        {
            _apiService = apiService;
        }   

        [HttpGet]
        public async Task<IActionResult> ShowEmployAll()
        {
            var result = await _apiService.GetEmployAsync();
            return Ok(result);
        }

        [HttpGet("{id}")] 
        public async    Task<IActionResult> SearchEmploy(int id)
        {
            var result = await _apiService.GetEmployByIdAsync(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }

        [HttpPost] 
        public async Task<IActionResult> AddEmploy(Employ employ)
        {
            var result = await _apiService.CreateEmployAsync(employ);
            return Ok(result);
        }
    }
}
