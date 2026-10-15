using System;

namespace DPM235503_LeThiKimYen_Refactoring47_ReplaceExceptionWithTest
{
    public class BeforeExample
    {
        private double[] _values = new double[] { 10, 20, 30 };

        // Lạm dụng Try-Catch để xử lý tràn chỉ số mảng
        public double GetValue(int index)
        {
            try
            {
                return _values[index];
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}