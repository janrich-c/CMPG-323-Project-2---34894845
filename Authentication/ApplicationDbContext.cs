using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CMPG323_Project2___34894845.Models;

namespace JWTAuthentication.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<CMPG323_Project2___34894845.Models.Category> Category { get; set; }
        public DbSet<CMPG323_Project2___34894845.Models.Device> Device { get; set; }
        public DbSet<CMPG323_Project2___34894845.Models.Zone> Zone { get; set; }
    }
}


