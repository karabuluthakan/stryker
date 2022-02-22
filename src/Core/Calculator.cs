namespace Core;

/// <summary>
/// 
/// </summary>
public class Calculator
{
    public int Addition(int first, int second)
    {
        return first + second;
    }

    public int Subtraction(int first, int second)
    {
        return first - second;
    }

    public int Multiplication(int first, int second)
    {
        return first * second;
    }

    public (int divided, int undivided) Division(int first, int second)
    {
        if (first.Equals(0) && second.Equals(0))
        {
            throw new ArithmeticException("Zero divided by zero is an indefinite operation.");
        }

        if (second.Equals(0))
        {
            throw new DivideByZeroException();
        }

        return (first / second, first % second);
    }
}