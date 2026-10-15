namespace DPM235503_LeThiKimYen_Refactoring45_ReplaceConstructorWithFactoryMethod
{
    public class EmployeeBefore
    {
        public int Type { get; set; }

        // Constructor dùng mã số mơ hồ
        public EmployeeBefore(int type)
        {
            Type = type;
        }
    }
}