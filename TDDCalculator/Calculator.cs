using System.Text.RegularExpressions;

namespace TDDCalculator;

public class Calculator
{
    // Pattern for a number 
    private const string _numberPattern = "^\\s*\\d+\\s*$";

    // Pattern for a formula
    private const string _formulaPattern = "^\\s*(?<x>\\d+)\\s*(?<opp>[\\+\\-\\*\\/])\\s*(?<y>\\d+)\\s*$";

    /// <summary>
    /// Solves the given formula and returns the answer.
    /// </summary>
    /// <param name="formula">The formula to be evaluated.</param>
    /// <returns>The solution to the formula.</returns>
    /// <exception cref="ArgumentException">Thrown when the provided formula is invalid.</exception>
    /// <exception cref="DivideByZeroException">Thrown when the user attempts to divide by 0.</exception>
    public int Calculate(string formula)
    {
        var numberRegex = new Regex(_numberPattern);
        var formulaRegex = new Regex(_formulaPattern);

        if (formulaRegex.IsMatch(formula))
        {
            var formulaParts = formulaRegex.GetGroupNames();
            var match = formulaRegex.Match(formula);
            var matchedX = match.Groups.TryGetValue(formulaParts[1], out var xGroup);
            var matchedOpp = match.Groups.TryGetValue(formulaParts[2], out var oppGroup);
            var matchedY = match.Groups.TryGetValue(formulaParts[3], out var yGroup);
            if (matchedX && matchedOpp && matchedY)
            {
                var x = int.Parse(xGroup!.Value);
                var y = int.Parse(yGroup!.Value);
                switch (oppGroup!.Value)
                {
                    case "+": return _add(x, y);
                    case "-": return _subtract(x, y);
                    case "*": return _multiply(x, y);
                    case "/": return _divide(x, y);
                }
            }
        }

        if (numberRegex.IsMatch(formula)) return int.Parse(formula);
        throw new ArgumentException();
    }

    private int _add(int x, int y)
    {
        return x + y;
    }

    private int _subtract(int x, int y)
    {
        return x - y;
    }

    private int _multiply(int x, int y)
    {
        return x * y;
    }

    private int _divide(int x, int y)
    {
        return x / y;
    }
}
