namespace DPM235503_LeThiKimYen_Refactoring39_ConsolidateConditionalExpression
{
    public class BeforeExample
    {
        public double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;

            return 1000;
        }
    }
}