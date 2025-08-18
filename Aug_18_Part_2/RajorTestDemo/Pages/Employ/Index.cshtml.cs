using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajorTestDemo.Models;

namespace RajorTestDemo.Pages.Employ
{
    public class IndexModel : PageModel
    {
        private readonly RajorTestDemo.Models.EFCoreDbContext _context;

        public IndexModel(RajorTestDemo.Models.EFCoreDbContext context)
        {
            _context = context;
        }

        public IList<RajorTestDemo.Models.Employ> Employ { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employ = await _context.Employees.ToListAsync();
        }
    }
}
