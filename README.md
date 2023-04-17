# TDD Exercise
## Brief
Make a console app that can perform a basic mathematical operation (+ - * /) on two integers and return the answer in the console.

The user will type a formula like `1 + 2` or `7 * 6`, etc., hit the enter key and get the answer.
Whitespaces should be ignored.

If a single integer is given, just return that integer.

If a non-integer/non-numerical character is given, an error should be thrown.

If an invalid operator is given, an error should be thrown.

If the formula is not in the for `x [+-*/] y`, an error should be thrown.

## Task
First write code in `TestTDDCalculator/TestCalculator.cs` using the **Arrange** / **Act** / **Assert** style.
The test methods are already there, you need to fill them in. These tests should fail at first.

Then go to `TDDCalculator/Calculator.cs` and write code such that your tests will start to pass.

Once all your tests pass, have fun with your app!