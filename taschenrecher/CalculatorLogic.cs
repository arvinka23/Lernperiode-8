using System;

public class CalculatorLogic
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
    public static double Power(double a, double b) => Math.Pow(a, b);
    public static double SquareRoot(double a)
    {
        if (a < 0) throw new ArgumentOutOfRangeException("Cannot take the square root of a negative number.");
        return Math.Sqrt(a);
    }
    public static double CalculatePercentage(double total, double percentage) => total * (percentage / 100);
}
