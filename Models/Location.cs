using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<LocationText> Texts { get; set; } = new();
        public List<Item> Items { get; set; } = new();
        public List<Game> Games { get; set; } = new();
        public List<Exit> Exits { get; set; } = new();
        [Computed]
        public List<Exit> VisibleExits
        {
            get { return Exits.Where(e => e.Visible).ToList(); }
        }
    }
}
