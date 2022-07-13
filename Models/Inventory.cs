using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public Item Item { get; set; } = new();
        public int Count { get; set; }
    }
}
