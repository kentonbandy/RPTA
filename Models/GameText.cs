using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class GameText
    {
        [Key]
        public int TextId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
