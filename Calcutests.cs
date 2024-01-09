using Xunit;

// 9.25
public class CalculatorTests 
{
    [Fact]
    public void TestAddition()
    {
        // given 
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // when
        int result = calc.Add(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void TestSubtraction()
    {
        // given 
        Calculator calc = new();
        int a = 6;
        int b = 2;
        int expectedResult = 4;

        // when
        int result = calc.Subtract(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void TestMultiply()
    {
        // given 
        Calculator calc = new();
        int a = 6;
        int b = 2;
        int expectedResult = 10;

        // when
        int result = calc.Multiply(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }

}