using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Simple static items. These objects should NOT be changed by game logic, only referenced.
    /// </summary>
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; }
        public ItemType Type { get; set; } = new();
        public int Action { get; set; }
        public int Weight { get; set; }
        public GameText Text { get; set; } = new();
        public List<Location> Locations { get; set; }
    }
}