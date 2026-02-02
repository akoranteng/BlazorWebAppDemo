using Microsoft.EntityFrameworkCore;
using BlazoWebAppDemo.Data;

namespace BlazoWebAppDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            // Optional: Log connection string for debugging
            Console.WriteLine($"Using DB: {Database.GetDbConnection().ConnectionString}");
        }

        public DbSet<Product> Products { get; set; }

        // Optional: override OnModelCreating if you want to configure entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example: configure Product table name explicitly
            modelBuilder.Entity<Product>().ToTable("Products");

            // Add more configurations here if needed
        }
    }
}