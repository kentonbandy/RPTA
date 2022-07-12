using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int level { get; set; }
        public Pronouns Pronouns { get; set; } = new();
        public GameText Text { get; set; } = new();
        public List<Inventory> Items { get; set; } = new();
    }
}
