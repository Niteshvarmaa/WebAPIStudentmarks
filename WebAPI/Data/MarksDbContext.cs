using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MarksDbContext : DbContext
    {
        public MarksDbContext (DbContextOptions<MarksDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Student> Student { get; set; } = default!;
    }
}
