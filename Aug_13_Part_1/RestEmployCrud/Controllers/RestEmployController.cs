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
        public async Task<IActionResult> ShowEmploys()
        {
            var users = await _apiService.GetEmployAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchEmploy(int id)
        {
            var user = await _apiService.GetEmployByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmploy(Employ employ)
        {
            var created = await _apiService.CreateEmployAsync(employ);
            return Ok(created);
        }
    }
}
