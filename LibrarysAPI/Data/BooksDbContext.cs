using LibrarysAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Data
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
