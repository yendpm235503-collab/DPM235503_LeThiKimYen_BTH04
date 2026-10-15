namespace DPM235503_LeThiKimYen_Refactoring39_ConsolidateConditionalExpression
{
    public class AfterExample
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
                return 0;

            return 1000;
        }

        private bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return (seniority < 2) || (monthsDisabled > 12) || isPartTime;
        }
    }
}