using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SalesTracker.Models
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
