namespace RPTA.Models
{
    /// <summary>
    /// For any non-null field (Power - Log), performs the operation using the given int value on an input value.
    /// If multiple fields are not null, performs the calculations in the order of the fields.
    /// To do calculations in different orders, use multiple StatCalculations in a Formula.
    /// </summary>
    public class StatCalculation
    {
        public int StatCalculationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Power { get; set; }
        public int? Log { get; set; }
        public int? Mult { get; set; }
        public int? Div { get; set; }
        public int? Add { get; set; }
        public int? Sub { get; set; }
        public List<Formula> Formulas { get; set; } = new();
        public int PerformCalc(int i)
        {
            if (Power != null) i = (int)Math.Pow(i, Power.Value);
            if (Log != null) i = (int)Math.Log(i, Log.Value);
            if (Mult != null) i *= Mult.Value;
            if (Div != null) i /= Div.Value;
            if (Add != null) i += Add.Value;
            if (Sub != null) i -= Sub.Value;
            return i;
        }
    }
}
