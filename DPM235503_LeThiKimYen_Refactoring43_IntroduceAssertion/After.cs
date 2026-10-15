using System.Diagnostics;

namespace DPM235503_LeThiKimYen_Refactoring43_IntroduceAssertion
{
    public class AfterExample
    {
        private double _expenseLimit = 1000;

        public double GetExpenseLimit()
        {
            // Khẳng định điều kiện đúng trước khi thực thi
            Debug.Assert(_expenseLimit >= 0, "Hạn mức chi phí không được âm!");
            return _expenseLimit;
        }
    }
}