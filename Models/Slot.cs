using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Models one slot of a Container. Uses SlotItems to denote which items are permitted in this slot.
    /// Item denotes the content of the slot. If Item == null, the slot is empty.
    /// </summary>
    public class Slot
    {
        [Key]
        public int SlotId { get; set; }
        public Container Container { get; set; } = new();
        public Item? Item { get; set; } = null;
        public List<SlotItem> AcceptedItems { get; set; } = new();
    }
}
