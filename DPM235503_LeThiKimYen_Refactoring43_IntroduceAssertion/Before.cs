namespace DPM235503_LeThiKimYen_Refactoring43_IntroduceAssertion
{
    public class BeforeExample
    {
        private double _expenseLimit = -1;

        public double GetExpenseLimit()
        {
            // Giả định _expenseLimit luôn > 0 nhưng không kiểm tra
            return _expenseLimit;
        }
    }
}