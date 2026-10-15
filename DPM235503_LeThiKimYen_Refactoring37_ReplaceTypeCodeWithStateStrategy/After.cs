namespace DPM235503_LeThiKimYen_Refactoring37_ReplaceTypeCodeWithStateStrategy
{
    public abstract class EmployeeType
    {
        public abstract double GetPay(double baseSalary);
    }

    public class EngineerType : EmployeeType
    {
        public override double GetPay(double baseSalary) => baseSalary;
    }

    public class SalesmanType : EmployeeType
    {
        public override double GetPay(double baseSalary) => baseSalary * 1.2;
    }

    public class EmployeeAfter
    {
        public EmployeeType Type { get; set; }

        public double GetPay(double baseSalary) => Type.GetPay(baseSalary);
    }
}