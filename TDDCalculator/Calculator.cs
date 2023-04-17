namespace TDDCalculator;

public class Calculator
{
    // Pattern for a number 
    private const string _numberPattern = "^\\s*\\d+\\s*$";
    // Pattern for a formula
    private const string _formulaPattern = "^\\s*(\\d+)\\s*([\\+\\-\\*\\/])\\s*(\\d+)\\s*$";

    /// <summary>
    /// Solves the given formula and returns the answer.
    /// </summary>
    /// <param name="formula">The formula to be evaluated.</param>
    /// <returns>The solution to the formula.</returns>
    /// <exception cref="ArgumentException">Thrown when the provided formula is invalid.</exception>
    /// <exception cref="DivideByZeroException">Thrown when the user attempts to divide by 0.</exception>
    public int Calculate(string formula)
    {
    }

    private int _add(int x, int y)
    {
    }
    
    private int _subtract(int x, int y)
    {
    }

    private int _multiply(int x, int y)
    {
    }
    
    private int _divide(int x, int y)
    {
    }
}