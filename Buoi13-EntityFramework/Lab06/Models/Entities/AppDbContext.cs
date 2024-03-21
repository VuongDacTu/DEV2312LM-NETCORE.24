using Lab06.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Lab06.Models.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
    }
}
