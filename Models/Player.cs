namespace RPTA.Models
{
    /// <summary>
    /// The user's character.
    /// To use simply inventory count, set items to weight 1 and MaxItemWeight to however many items you want to be able to carry.
    /// </summary>
    public class Player : Character
    {
        public int PlayerId { get; set; }
        public int MaxItemWeight { get; set; }
        public List<PlayerSlot> PlayerSlots { get; set; } = new();
    }
}
