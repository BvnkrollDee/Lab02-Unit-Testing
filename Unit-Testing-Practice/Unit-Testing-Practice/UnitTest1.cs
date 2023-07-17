namespace Unit_Testing_Practice;
using ATM;
public class UnitTest1
{
    [Theory]
    [InlineData(0, 0)]
    public void viewBalanceTest(decimal expectedResult, decimal value)
    {
        value = Program.ViewBalance();
        Assert.Equal(expectedResult, value);
    }














}
