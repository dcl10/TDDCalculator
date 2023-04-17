// See https://aka.ms/new-console-template for more information

using TDDCalculator;

Console.WriteLine(@"Welcome to TED Calculator.
Enter a formula to solve (e.g. 7 * 6). Use + to add, - to subtract, * to multiply and / to divide.
");
var calculator = new Calculator();
var formula = Console.ReadLine();
if (formula is not null)
{
    var result = calculator.Calculate(formula);
    Console.WriteLine($"{formula} = {result}");
}
else
{
    Console.WriteLine("Sorry, you didn't provide a formula.");
}