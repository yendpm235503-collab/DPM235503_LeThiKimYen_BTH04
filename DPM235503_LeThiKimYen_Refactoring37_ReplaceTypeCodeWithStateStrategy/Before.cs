namespace DPM235503_LeThiKimYen_Refactoring37_ReplaceTypeCodeWithStateStrategy
{
    public class EmployeeBefore
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public int Type { get; set; }

        public double GetPay(double baseSalary)
        {
            if (Type == ENGINEER) return baseSalary;
            return baseSalary * 1.2;
        }
    }
}