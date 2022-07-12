using System.ComponentModel.DataAnnotations;

namespace RPTA.Models
{
    public class Pronouns
    {
        [Key]
        public int PronounsId { get; set; }
        public string SingularNominative { get; set; } = "they";
        public string ThirdObjective { get; set; } = "them";
        public string PossessiveNominative { get; set; } = "their";
        public string PossessiveObjective { get; set; } = "theirs";
    }
}
