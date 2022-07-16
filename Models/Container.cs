using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// A container that holds items.
    /// </summary>
    public class Container
    {
        [Key]
        public int ContainerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public GameText Text { get; set; } = new();
        public List<Location> Locations { get; set; } = new();
        public List<Slot> Slots { get; set; } = new();
        [Computed]
        public bool Full
        {
            get
            {
                return Slots.All(s => s.Item != null);
            }
        }
    }
}
