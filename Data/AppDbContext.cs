using Microsoft.EntityFrameworkCore;
using Dailee_Konnekt.Models;

namespace Dailee_Konnekt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}