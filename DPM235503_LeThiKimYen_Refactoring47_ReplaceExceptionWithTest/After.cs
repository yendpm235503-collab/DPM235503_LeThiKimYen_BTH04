namespace DPM235503_LeThiKimYen_Refactoring47_ReplaceExceptionWithTest
{
    public class AfterExample
    {
        private double[] _values = new double[] { 10, 20, 30 };

        // Thay bằng câu lệnh kiểm tra điều kiện (Test)
        public double GetValue(int index)
        {
            if (index < 0 || index >= _values.Length)
            {
                return 0;
            }
            return _values[index];
        }
    }
}