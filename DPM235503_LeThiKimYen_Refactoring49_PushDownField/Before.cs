namespace DPM235503_LeThiKimYen_Refactoring49_PushDownField
{
    public abstract class EmployeeBefore
    {
        // Quota chỉ dùng duy nhất cho Salesman nhưng lại đặt ở Lớp cha
        public double SalesQuota { get; set; }
    }

    public class SalesmanBefore : EmployeeBefore { }
    public class EngineerBefore : EmployeeBefore { }
}