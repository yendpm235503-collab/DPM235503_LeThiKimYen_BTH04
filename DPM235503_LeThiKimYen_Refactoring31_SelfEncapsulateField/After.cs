namespace DPM235503_LeThiKimYen_Refactoring31_SelfEncapsulateField
{
    public class AfterExample
    {
        private int _low;
        private int _high;

        public AfterExample(int low, int high)
        {
            Low = low;
            High = high;
        }

        public int Low { get => _low; set => _low = value; }
        public int High { get => _high; set => _high = value; }

        // Tự đóng gói: dùng Property Getter/Setter ngay trong chính nội bộ Class
        public bool Includes(int arg)
        {
            return arg >= Low && arg <= High;
        }
    }
}