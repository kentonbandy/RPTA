using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPTA.Models
{
    public class Exit
    {
        public int ExitId { get; set; }
        public Direction Direction { get; set; } = new();
        public Location Destination { get; set; } = new();
        public Condition? Condition { get; set; } = new();
        [Computed]
        public bool Visible { get { return Condition?.Satisfied ?? true; } }
    }
}
