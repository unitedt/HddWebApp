using Microsoft.EntityFrameworkCore;

namespace HddWebApp.Models
{
    public class HddContext : DbContext
    {
        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<Disk> Disks { get; set; }

        public HddContext(DbContextOptions<HddContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
