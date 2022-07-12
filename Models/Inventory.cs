using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        [Required]
        public int CharacterId { get; set; }
        public int? ItemId { get; set; }

        public Item Item { get; set; } = new();
        public int Count { get; set; }
    }
}
