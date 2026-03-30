using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;

namespace backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add DbSet entities here as needed for the application
        // Example: public DbSet<EntityName> EntityNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure Oracle-specific mappings if needed
        }
    }
}