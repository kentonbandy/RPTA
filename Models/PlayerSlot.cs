namespace RPTA.Models
{
    public class PlayerSlot
    {
        public int PlayerSlotId { get; set; }
        public int SlotOrder { get; set; }
        public ItemType ItemType { get; set; } = new();
        public Item? EquippedItem { get; set; } = null;
    }
}
