namespace RPTA.Models
{
    public class LocationExit
    {
        public int LocationId { get; set; }
        public int ExitId { get; set; }
        public Exit Exit { get; set; } = new();
    }
}
