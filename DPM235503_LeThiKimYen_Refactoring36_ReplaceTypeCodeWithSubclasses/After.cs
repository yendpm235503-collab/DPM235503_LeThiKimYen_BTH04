namespace DPM235503_LeThiKimYen_Refactoring36_ReplaceTypeCodeWithSubclasses
{
    public abstract class EmployeeAfter
    {
        public abstract double GetMonthlySalary(double baseSalary);
    }

    public class Engineer : EmployeeAfter
    {
        public override double GetMonthlySalary(double baseSalary) => baseSalary;
    }

    public class Salesman : EmployeeAfter
    {
        public override double GetMonthlySalary(double baseSalary) => baseSalary + 500;
    }

    public class Manager : EmployeeAfter
    {
        public override double GetMonthlySalary(double baseSalary) => baseSalary + 1000;
    }
}