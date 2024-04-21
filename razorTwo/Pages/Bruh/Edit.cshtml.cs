using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razorTwo.Data;
using razorTwo.Models;

namespace razorTwo.Pages.Bruh
{
    public class EditModel : PageModel
    {
        private readonly razorTwo.Data.razorTwoContext _context;

        public EditModel(razorTwo.Data.razorTwoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Resources Resources { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resources =  await _context.Resources.FirstOrDefaultAsync(m => m.Id == id);
            if (resources == null)
            {
                return NotFound();
            }
            Resources = resources;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Resources).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourcesExists(Resources.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ResourcesExists(int id)
        {
            return _context.Resources.Any(e => e.Id == id);
        }
    }
}
