namespace Unit_Testing_Practice;
using ATM;
public class UnitTest1
{
    [Theory]
    [InlineData(500)]
    public void viewBalanceTest(decimal expectedResult)
    {
        decimal value = Program.ViewBalance();
        Assert.Equal(expectedResult, value);
    }


    [Theory]
    [InlineData(500, 500)]
    public void DepositTest(decimal expectedResult, decimal value)
    {
        decimal newBalance = Program.Deposit(value);
        Assert.Equal(expectedResult, newBalance);

    }


    [Theory]
    [InlineData(0, 500)]
    public void WithdrawTest(decimal expectedResult, decimal value)
    {
        decimal newBalance = Program.Withdraw(value);
        Assert.Equal(expectedResult, value);
    }













}
