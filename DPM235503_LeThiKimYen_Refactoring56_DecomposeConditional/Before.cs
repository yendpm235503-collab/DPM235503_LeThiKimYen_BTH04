using System;

namespace DPM235503_LeThiKimYen_Refactoring56_DecomposeConditional
{
    public class BeforeExample
    {
        public double GetCharge(DateTime date, int quantity, double summerRate, double winterRate, double winterServiceCharge)
        {
            double charge;
            // Biểu thức điều kiện phức tạp gây khó đọc
            if (date.Month < 6 || date.Month > 8)
            {
                charge = quantity * winterRate + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerRate;
            }
            return charge;
        }
    }
}