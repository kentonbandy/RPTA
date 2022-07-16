using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public List<Stat> Stats { get; set; } = new();
        public List<Location> Locations { get; set; } = new();
        public List<Inventory> Inventory { get; set; } = new();
        [NotMapped]
        public Dictionary<Stat, int> StatValues { get; set; } = new();

        public Dictionary<Stat, int> GetStatMaxValues()
        {
            var statVals = new Dictionary<Stat, int>();
            foreach (var stat in Stats)
            {
                statVals[stat] = CalculateStatValue(stat);
            }
            return statVals;
        }

        public int CalculateStatValue(Stat stat)
        {
            int statVal = Level;
            foreach (StatCalculation calc in stat.Formula.Calculations)
            {
                statVal = calc.PerformCalc(statVal);
            }
            return statVal;
        }
    }
}
