namespace DPM235503_LeThiKimYen_Refactoring48_PullUpField
{
    public abstract class EmployeeBefore { }

    public class SalesmanBefore : EmployeeBefore
    {
        public string Name { get; set; } // Khai báo trùng lặp
    }

    public class EngineerBefore : EmployeeBefore
    {
        public string Name { get; set; } // Khai báo trùng lặp
    }
}