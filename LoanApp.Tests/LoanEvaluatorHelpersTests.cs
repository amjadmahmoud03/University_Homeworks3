namespace LoanApp.Tests;
using LoanApp.Core;

public class LoanEvaluatorHelpersTests
{
    [Fact]
    public void EvaluateEmployed_Should_ReturnNotEligible_When_ScoreOver700AndMoreTwoDependents()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(800, 5, true);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void EvaluateEmployed_Should_ReturnReviewManually_When_ScoreOver600AndOwnsHouse()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(650, 5, true);
        Assert.Equal("Review Manually", result);
    }

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnEligible_When_ScoreOver750AndInComeOver5000AndOwnsHouse()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(5500, 1000, 2, true);
        Assert.Equal("Eligible", result);
    }

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnReviewManually_When_ScoreOver650AndNoDependents()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(3000, 1000, 0, true);
        Assert.Equal("Review Manually", result);
    }

}