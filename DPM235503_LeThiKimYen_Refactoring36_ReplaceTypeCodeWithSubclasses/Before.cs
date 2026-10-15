namespace DPM235503_LeThiKimYen_Refactoring36_ReplaceTypeCodeWithSubclasses
{
    public class EmployeeBefore
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; set; }

        public EmployeeBefore(int type)
        {
            Type = type;
        }

        public double GetMonthlySalary(double baseSalary)
        {
            switch (Type)
            {
                case ENGINEER: return baseSalary;
                case SALESMAN: return baseSalary + 500;
                case MANAGER: return baseSalary + 1000;
                default: return baseSalary;
            }
        }
    }
}