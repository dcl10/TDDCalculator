using TDDCalculator;

namespace TestTDDCalculator;

public class TestCalculator
{
    [Fact]
    public void Calculate_SingleNumber_ReturnsSameNumber()
    {
        // Arrange
        var formula = "42";
        var expectedAnswer = 42;
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = calculator.Calculate(formula);
        
        // Assert
        Assert.Equal(expectedAnswer, actualAnswer);
    }
    
    [Fact]
    public void Calculate_AddTwoNumbers_ReturnsSum()
    {
        // Arrange
        var formula = "40 + 2";
        var expectedAnswer = 42;
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = calculator.Calculate(formula);
        
        // Assert
        Assert.Equal(expectedAnswer, actualAnswer);
    }
    
    [Fact]
    public void Calculate_SubtractTwoNumbers_ReturnsDifference()
    {
        // Arrange
        var formula = "44 - 2";
        var expectedAnswer = 42;
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = calculator.Calculate(formula);
        
        // Assert
        Assert.Equal(expectedAnswer, actualAnswer);
    }
    
    [Fact]
    public void Calculate_MultiplyTwoNumbers_ReturnsProduct()
    {
        // Arrange
        var formula = "7 * 6";
        var expectedAnswer = 42;
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = calculator.Calculate(formula);
        
        // Assert
        Assert.Equal(expectedAnswer, actualAnswer);
    }
    
    [Fact]
    public void Calculate_DivideTwoNumbers_ReturnsQuotient()
    {
        // Arrange
        var formula = "84 / 2";
        var expectedAnswer = 42;
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = calculator.Calculate(formula);
        
        // Assert
        Assert.Equal(expectedAnswer, actualAnswer);
    }
    
    [Fact]
    public void Calculate_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var formula = "42 / 0";
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = () => calculator.Calculate(formula);
        
        // Assert
        Assert.Throws<DivideByZeroException>(() => actualAnswer());
    }
    
    [Fact]
    public void Calculate_WithNonIntegerArgs_ThrowsArgumentException()
    {
        // Arrange
        var formula = "42 / abc";
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = () => calculator.Calculate(formula);
        
        // Assert
        Assert.Throws<ArgumentException>(() => actualAnswer());
    }
    
    [Fact]
    public void Calculate_WithInvalidOperator_ThrowsArgumentException()
    {
        // Arrange
        var formula = "40 & 2";
        var calculator = new Calculator();
        
        // Act
        var actualAnswer = () => calculator.Calculate(formula);
        
        // Assert
        Assert.Throws<ArgumentException>(() => actualAnswer());
    }
}