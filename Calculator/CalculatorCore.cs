using System.Linq;

namespace Calculator
{
    public class CalculatorCore:ICalculatorCore
    {
        public double Sum(params double[] values)
        {
            return values.Aggregate(0d, (current, value) => current + value);
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Multiply(params double[] values)
        {
            return values.Aggregate(1d, (current, value) => current * value);
        }

        public double Divide(double a, double b)
        {
            return a/b;
        }
    }
}
