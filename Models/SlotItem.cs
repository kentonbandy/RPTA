namespace RPTA.Models
{
    /// <summary>
    /// Allows this item to be placed in this slot (if it isn't already filled).
    /// </summary>
    public class SlotItem
    {
        public int SlotId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; } = new();
    }
}
