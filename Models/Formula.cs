namespace RPTA.Models
{
    /// <summary>
    /// Provides a list of calculations to be performed on an integer. Complex calculations are possible using any combinations of exponent, log, multiplication, division, addition, subtraction.
    /// Suggested defaults: linear increase, exponential increase, logarithmic increase
    /// </summary>
    public class Formula
    {
        public int FormulaId { get; set; }
        public String Name { get; set; } = string.Empty;
        // List of operations/values to be performed in order on the character's level as the initial value.
        public List<StatCalculation> Calculations { get; set; } = new();
    }
}
