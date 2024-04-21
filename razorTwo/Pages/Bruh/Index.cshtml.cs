using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorTwo.Data;
using razorTwo.Models;

namespace razorTwo.Pages.Bruh
{
    public class IndexModel : PageModel
    {
        private readonly razorTwo.Data.razorTwoContext _context;

        public IndexModel(razorTwo.Data.razorTwoContext context)
        {
            _context = context;
        }

        public IList<Resources> Resources { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Resources = await _context.Resources.ToListAsync();
        }
    }
}
