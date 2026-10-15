namespace DPM235503_LeThiKimYen_Refactoring55_ReplaceDelegationWithInheritance
{
    public class PersonAfter
    {
        public string Name { get; set; }
    }

    // Chuyển sang kế thừa vì Nhân viên thực sự LÀ Một Con người
    public class EmployeeAfter : PersonAfter { }
}