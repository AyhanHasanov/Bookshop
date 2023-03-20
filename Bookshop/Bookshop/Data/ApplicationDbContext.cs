using Bookshop.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookshop.Data
{
    public class ApplicationDbContext : DbContext
    {
    //    public ApplicationDbContext(DbContextOptions options)
    //        : base(options)
    //    {
    //    }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(@"Data Source=bookshop.db");

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Courrier> Courriers { get; set; }
    }
}
