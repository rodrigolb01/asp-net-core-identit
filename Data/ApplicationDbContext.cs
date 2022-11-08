using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentityPractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
         }
        public DbSet<AspNetCoreIdentityPractice.Models.Credential> Credentials { get; set; }
    }
}
