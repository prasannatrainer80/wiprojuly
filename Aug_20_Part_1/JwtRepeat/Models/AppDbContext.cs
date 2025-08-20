using Microsoft.EntityFrameworkCore;

namespace JwtRepeat.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
