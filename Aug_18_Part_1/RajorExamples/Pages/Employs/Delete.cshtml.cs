using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajorExamples.Models;

namespace RajorExamples.Pages.Employs
{
    public class DeleteModel : PageModel
    {
        private readonly EFCoreDbContext _context; 

        public DeleteModel(EFCoreDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employ Employ { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees.FindAsync(id);
            if (employ != null)
            {
                Employ = employ;
                _context.Employees.Remove(Employ);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employees.Where(x => x.Empno == id).FirstOrDefaultAsync();

            //var employ = await _dbContext.Employees.FirstOrDefaultAsync(m => m.Empno == id);
            if (employ == null)
            {
                return NotFound();
            }
            else
            {
                Employ = employ;
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
