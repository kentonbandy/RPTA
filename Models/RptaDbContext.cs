using Microsoft.EntityFrameworkCore;

namespace RPTA.Models
{
    public class RptaDbContext : DbContext
    {
        public RptaDbContext(DbContextOptions<RptaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // keeping this here just in case
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Pronouns> Pronouns { get; set; }
        public DbSet<GameText> GameText { get; set; }
    }
}
