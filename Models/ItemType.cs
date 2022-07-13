using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class ItemType
    {
        [Key]
        public int TypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Equippable { get; set; }
    }
}
