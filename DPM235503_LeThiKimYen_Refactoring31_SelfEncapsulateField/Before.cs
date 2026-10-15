namespace DPM235503_LeThiKimYen_Refactoring31_SelfEncapsulateField
{
    public class BeforeExample
    {
        private int _low;
        private int _high;

        public BeforeExample(int low, int high)
        {
            _low = low;
            _high = high;
        }

        // Truy cập trực tiếp biến cờ nội bộ thay vì đi qua Getter/Setter
        public bool Includes(int arg)
        {
            return arg >= _low && arg <= _high;
        }
    }
}