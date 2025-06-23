namespace LoanApp.Tests;
using LoanApp.Core;

public class LoanEvaluatorHelpersTests
{
    // EvaluateEmployed Testing
    [Fact]
    public void EvaluateEmployed_Should_ReturnEligible_When_ScoreOver700AndNoDependents()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(800, 0, true);
        Assert.Equal("Eligible", result);
    }

    [Fact]
    public void EvaluateEmployed_Should_ReturnReviewManually_When_ScoreOver700AndLessOrEqualTwoDependents()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(800, 2, true);
        Assert.Equal("Review Manually", result);
    }

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
    public void EvaluateEmployed_Should_ReturnNotEligible_When_ScoreOver600AndNotOwnsHouse()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(600, 5, false);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void EvaluateEmployed_Should_ReturnNotEligible_When_PreviousIsFalse()
    {
        var result = LoanEvaluatorHelpers.EvaluateEmployed(500, 5, false);
        Assert.Equal("Not Eligible", result);
    }



    // EvaluateUnEmployed Testing
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

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnNotEligible_When_ScoreLess650()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(5000, 500, 0, true);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnNotEligible_When_ScoreOver750AndNotOwnsHouseAndOneDependent()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(5000, 1000, 1, false);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnNotEligible_When_ScoreOver750AndIncomeLessThan5000AndOneDependent()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(4000, 1000, 1, true);
        Assert.Equal("Not Eligible", result);
    }

    [Fact]
    public void EvaluateUnEmployed_Should_ReturnNotEligible_When_ScoreOver650AndOneDependent()
    {
        var result = LoanEvaluatorHelpers.EvaluateUnEmployed(5000, 670, 1, true);
        Assert.Equal("Not Eligible", result);
    }



}