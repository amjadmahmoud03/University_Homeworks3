namespace LoanApp.Core;

public static class LoanEvaluator
{
    public static string GetLoanEligibility(int income, bool hasJob, int creditScore, int dependents, bool ownsHouse)
    {
        if (IsLowIncome(income))
            return "Not Eligible";

        if (hasJob)
            return LoanEvaluatorHelpers.EvaluateEmployed(creditScore, dependents, ownsHouse);
        else
            return LoanEvaluatorHelpers.EvaluateUnEmployed(income, creditScore, dependents, ownsHouse);
    }

    private static bool IsLowIncome(int income) => income < 2000;
}
