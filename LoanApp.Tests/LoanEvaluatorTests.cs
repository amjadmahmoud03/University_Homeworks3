namespace LoanApp.Tests;

using LoanApp.Core;

public class LoanEvaluatorTests
{
    [Fact]
    public void GetLoanEligibility_Should_Return_NotEligible_When_Income_Low()
    {
        var result = LoanEvaluator.GetLoanEligibility(1500, true, 800, 5, true);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void GetLoanEligibility_Should_Return_ReviewManually_When_HasJob()
    {
        var result = LoanEvaluator.GetLoanEligibility(2200, true, 800, 2, true);
        Assert.Equal("Review Manually", result);
    }

    [Fact]
    public void GetLoanEligibility_Should_Return_Eligible_When_UnHasJob()
    {
        var result = LoanEvaluator.GetLoanEligibility(5500, false, 800, 2, true);
        Assert.Equal("Eligible", result);
    }
}
