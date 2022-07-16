namespace RPTA.Models
{
    /// <summary>
    /// Stats are customizable in RPTA.
    /// Each character and player can have custom stats.
    /// Stats are affected by actions and items (traditionally, HP (stat) is affected by attack (action) or potion (item))
    /// </summary>
    public class Stat
    {
        public int StatId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public Formula Formula { get; set; } = new();
        // a message that displays when this stat is getting low
        public string AlarmMessage { get; set; } = string.Empty;
        // threshold at which the AlarmMessage is shown (this is a percent of the stat's max value)
        public int AlarmThreshold { get; set; }
    }
}
