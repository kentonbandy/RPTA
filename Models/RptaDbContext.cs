
namespace RPTA.Models
{
    public class RptaDbContext : DbContext
    {
        public RptaDbContext(DbContextOptions<RptaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SlotItem>().HasKey(s => new { s.SlotId, s.ItemId });
            modelBuilder.Entity<LocationExit>().HasKey(l => new { l.LocationId, l.ExitId });
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Pronouns> Pronouns { get; set; }
        public DbSet<GameText> GameText { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<LocationText> LocationText { get; set; }
        public DbSet<Container> Container { get; set; }
        public DbSet<Slot> Slot { get; set; }
        public DbSet<SlotItem> SlotItem { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Term> Term { get; set; }
        public DbSet<Font> Font { get; set; }
        public DbSet<Exit> Exit { get; set; }
        public DbSet<Direction> Direction { get; set; }
        public DbSet<LocationExit> LocationExit { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Save> Save { get; set; }
        public DbSet<Formula> Formula { get; set; }
        public DbSet<StatCalculation> StatCalculation { get; set; }
        public DbSet<PlayerSlot> PlayerSlot { get; set; }
    }
}
