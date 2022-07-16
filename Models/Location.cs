using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Models the places a player can go. Exits/directions are customizable.
    /// Holds all necessary data below Game besides Player. Copying a location makes a new copy of all child/referenced data (except Items, which are unchanging).
    /// </summary>
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<LocationText> Texts { get; set; } = new();
        public List<Item> Items { get; set; } = new();
        public List<Game> Games { get; set; } = new();
        public List<Character> Characters { get; set; } = new();
        public List<Container> Containers { get; set; } = new();
        public List<LocationExit> Exits { get; set; } = new();
        [Computed]
        public List<Exit> VisibleExits
        {
            get { return Exits.Select(e => e.Exit).Where(e => e.Visible).ToList(); }
        }
    }
}
