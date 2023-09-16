namespace CalculatorClassLibrary
{
    /// <summary>
    /// The basic operands +,-,* and /
    /// </summary>
    public class MathsFunctions : IMathsFunctions
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public decimal GetRemainder(decimal a, decimal b)
        {
            return a % b;
        }
    }
}