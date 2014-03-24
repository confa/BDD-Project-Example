namespace Calculator
{
    public interface ICalculatorCore
    {
        double Sum(params double[] values);
        double Minus(double a, double b);
        double Multiply(params double[] values);
        double Divide(double a, double b);
    }
}