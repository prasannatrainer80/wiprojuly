using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestEmployCrud.Models;

namespace RestEmployCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploysNewController : ControllerBase
    {
        private readonly EmployDbContext _context;

        public EmploysNewController(EmployDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employ>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employ>> GetResult(int id)
        {
            var employ = await _context.Employees.Where(x => x.Empno == id).SingleOrDefaultAsync();
            if (employ == null)
            {
                return NotFound();
            }
            return employ;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddEmploy(Employ employ)
        {
            _context.Employees.Add(employ);
            await _context.SaveChangesAsync();
            return "Employ Record Inserted...";
        }
    }
}
