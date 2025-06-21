namespace LoanApp.Core;

public static class LoanEvaluatorHelpers
{
    public static string EvaluateEmployed(int creditScore, int dependents, bool ownsHouse)
    {
        if (creditScore >= 700)
        {
            if (dependents == 0) return "Eligible";
            else if (dependents <= 2) return "Review Manually";
            return "Not Eligible";
        }

        else if (creditScore >= 600)
            return ownsHouse ? "Review Manually" : "Not Eligible";

        return "Not Eligible";
    }

    public static string EvaluateUnEmployed(int income, int creditScore, int dependents, bool ownsHouse)
    {
        if (creditScore >= 750 && income > 5000 && ownsHouse)
            return "Eligible";

        else if (creditScore >= 650 && dependents == 0)
            return "Review Manually";

        return "Not Eligible";
    }
}
