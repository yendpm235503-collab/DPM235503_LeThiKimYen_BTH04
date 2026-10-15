namespace DPM235503_LeThiKimYen_Refactoring51_ExtractSuperclass
{
    public abstract class PartyAfter
    {
        public string Name { get; set; }
        public abstract double GetAnnualCost();
    }

    public class DepartmentAfter : PartyAfter
    {
        public double AnnualCost { get; set; }
        public override double GetAnnualCost() => AnnualCost;
    }

    public class EmployeeAfter : PartyAfter
    {
        public double Salary { get; set; }
        public override double GetAnnualCost() => Salary * 12;
    }
}