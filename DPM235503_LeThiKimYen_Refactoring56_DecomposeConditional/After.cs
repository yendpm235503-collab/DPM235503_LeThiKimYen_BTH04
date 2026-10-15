using System;

namespace DPM235503_LeThiKimYen_Refactoring56_DecomposeConditional
{
    public class AfterExample
    {
        public double GetCharge(DateTime date, int quantity, double summerRate, double winterRate, double winterServiceCharge)
        {
            if (IsWinter(date))
            {
                return WinterCharge(quantity, winterRate, winterServiceCharge);
            }
            return SummerCharge(quantity, summerRate);
        }

        private bool IsWinter(DateTime date) => date.Month < 6 || date.Month > 8;
        private double WinterCharge(int quantity, double rate, double serviceCharge) => quantity * rate + serviceCharge;
        private double SummerCharge(int quantity, double rate) => quantity * rate;
    }
}