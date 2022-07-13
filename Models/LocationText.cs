using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPTA.Models
{
    public class LocationText
    {
        [Key]
        public int LocTextId { get; set; }
        public string LocationId { get; set; } = string.Empty;
        public GameText Text { get; set; } = new();
        public int Order { get; set; }
    }
}
