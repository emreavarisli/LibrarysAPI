using LibrarysAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarysAPI.Data
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
