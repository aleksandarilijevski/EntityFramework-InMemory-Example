using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    public class EFContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ExampleDatabase");
        }

        public DbSet<Song> Songs { get; set; }
    }
}
