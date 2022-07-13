using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    /// <summary>
    /// Model for a generic NPC
    /// </summary>
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public Pronouns Pronouns { get; set; } = new();
        public GameText Text { get; set; } = new();
        public List<Inventory> Inventory { get; set; } = new();
    }
}
