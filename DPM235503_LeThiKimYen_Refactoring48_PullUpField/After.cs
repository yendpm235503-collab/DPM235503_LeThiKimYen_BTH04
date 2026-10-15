namespace DPM235503_LeThiKimYen_Refactoring48_PullUpField
{
    public abstract class EmployeeAfter
    {
        public string Name { get; set; } // Kéo thuộc tính Name lên lớp cha
    }

    public class SalesmanAfter : EmployeeAfter { }
    public class EngineerAfter : EmployeeAfter { }
}