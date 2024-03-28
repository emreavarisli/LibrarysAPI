using LibrarysAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Data
{
    public class BorrowedBooksDbContext : DbContext
    {
        public BorrowedBooksDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
    }
}
