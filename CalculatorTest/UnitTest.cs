using CalculatorModel;

namespace HelloWorldTest;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        Assert.Equal(4, Calculator.Addition(2, 2));
    }
}