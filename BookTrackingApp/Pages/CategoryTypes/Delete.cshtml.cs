using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;

namespace BookTrackingApp.Pages.CategoryTypes
{
    public class DeleteModel : PageModel
    {
        private readonly Context_CategoryType _context;

        public DeleteModel(Context_CategoryType context)
        {
            _context = context;
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryType.FirstOrDefaultAsync(m => m.Type == id);

            if (CategoryType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryType.FindAsync(id);

            if (CategoryType != null)
            {
                _context.CategoryType.Remove(CategoryType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
