namespace DPM235503_LeThiKimYen_Refactoring45_ReplaceConstructorWithFactoryMethod
{
    public class EmployeeAfter
    {
        public int Type { get; private set; }

        private EmployeeAfter(int type)
        {
            Type = type;
        }

        // Dùng Factory Method thể hiện rõ ý nghĩa khởi tạo
        public static EmployeeAfter CreateManager() => new EmployeeAfter(1);
        public static EmployeeAfter CreateEngineer() => new EmployeeAfter(2);
    }
}