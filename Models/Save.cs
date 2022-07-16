using ServiceStack.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// A game in the playable/saved state.
    /// </summary>
    public class Save
    {
        public int SaveId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime SessionStartTime { get; set; } = new();
        public TimeSpan PlayTime { get; set; } = TimeSpan.Zero;
        public int GameId { get; set; }
        public Term Currency { get; set; } = new();
        public Term Weight { get; set; } = new();
        public Font Font { get; set; } = new();
        public Player Player { get; set; } = new();
        public List<Location> Locations { get; set; } = new();
        public int CurrentLocationId { get; set; }
        [Computed]
        public Location? CurrentLocation
        {
            get { return Locations.Find(l => l.LocationId == CurrentLocationId); }
        }
    }
}
