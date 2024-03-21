using Lesson06.Theory.CF.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Lesson06.Theory.CF.Models.BusinessModels
{
    public class BookManagementContext:DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options) { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book>  Book { get; set; }
    }
}
