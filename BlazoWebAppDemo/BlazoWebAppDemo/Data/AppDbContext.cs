using BlazoWebAppDemo.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
//using BlazoWebAppDemo.Data;


namespace BlazoWebAppDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
