namespace DPM235503_LeThiKimYen_Refactoring49_PushDownField
{
    public abstract class EmployeeAfter { }

    public class SalesmanAfter : EmployeeAfter
    {
        // Đẩy thuộc tính SalesQuota xuống đúng lớp con Salesman
        public double SalesQuota { get; set; }
    }

    public class EngineerAfter : EmployeeAfter { }
}