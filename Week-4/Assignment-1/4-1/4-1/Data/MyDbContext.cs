using _4_1.Models;
using Microsoft.EntityFrameworkCore;

namespace _4_1.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
