using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;

namespace backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure Oracle-specific mappings if needed

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users"); // Optional: specify table name
                entity.HasIndex(u => u.Email).IsUnique(); // Ensure email is unique
                entity.Property(u => u.CreatedAt)
                      .HasDefaultValueSql("SYSDATE"); // Oracle specific: set CreatedAt to current timestamp
            });
        }
    }
}