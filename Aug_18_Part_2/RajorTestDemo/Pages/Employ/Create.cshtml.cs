using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RajorTestDemo.Models;

namespace RajorTestDemo.Pages.Employ
{
    public class CreateModel : PageModel
    {
        private readonly RajorTestDemo.Models.EFCoreDbContext _context;

        public CreateModel(RajorTestDemo.Models.EFCoreDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RajorTestDemo.Models.Employ Employ { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(Employ);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
