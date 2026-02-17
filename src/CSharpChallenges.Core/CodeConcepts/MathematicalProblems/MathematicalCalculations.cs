namespace CSharpChallenges.Core.CodeConcepts.MathematicalProblems;

public class MathematicalCalculations
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b) 
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return (double) a / b;
    }

    public int Modulus(int a, int b) => a % b;

    public int Square(int a) => a * a;

    public int Cube(int a) => a * a * a;

    public double Power(int a, int b) => Math.Pow(a, b);

    public double SquareRoot(int a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Input must be a non-negative number.");
        }
        return Math.Sqrt(a);
    }

    public double Absolute(int a) => Math.Abs(a);

    public int Max(int a, int b) => Math.Max(a, b);

    public int Min(int a, int b) => Math.Min(a, b);

    public double Average(int a, int b) => (a + b) / 2.0;

    public Tuple<double, double> QuadraticEquation(double a, double b, double c)
    {
        var original = (b*b) - (4*a*c);

        var plus = (-b + Math.Sqrt(original))/(2*a); 
        var neg = (-b - Math.Sqrt(original))/(2*a); 
        
        return new Tuple<double, double>(plus,neg); 
    }
}
