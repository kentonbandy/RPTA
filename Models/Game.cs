using ServiceStack.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Contains all necessary data for a game. This is the default state for beginning a game that is copied to Save on start.
    /// </summary>
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Term Currency { get; set; } = new();
        public Term Weight { get; set; } = new();
        public Font Font { get; set; } = new();
        public List<Location> Locations { get; set; } = new();
        public int StartLocationId { get; set; }
        [Computed]
        public Location? StartLocation
        {
            get { return Locations.Find(l => l.LocationId == StartLocationId); }
        }
    }
}
