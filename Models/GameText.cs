using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class GameText
    {
        [Key]
        public int TextId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public List<Condition>? Conditions { get; set; } = null;
        [Computed]
        public bool Visible { get { return Conditions?.All(c => c.Satisfied) ?? true; } }
    }
}
