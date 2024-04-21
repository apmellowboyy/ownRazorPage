using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorTwo.Models;

namespace razorTwo.Data
{
    public class razorTwoContext : DbContext
    {
        public razorTwoContext (DbContextOptions<razorTwoContext> options)
            : base(options)
        {
        }

        public DbSet<razorTwo.Models.Resources> Resources { get; set; } = default!;
    }
}
