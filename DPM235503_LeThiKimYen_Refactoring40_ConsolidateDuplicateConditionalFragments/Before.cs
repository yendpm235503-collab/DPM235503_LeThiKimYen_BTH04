using System;

namespace DPM235503_LeThiKimYen_Refactoring40_ConsolidateDuplicateConditionalFragments
{
    public class BeforeExample
    {
        public void SendInvoice(bool isSpecialCustomer, double price)
        {
            double total;
            if (isSpecialCustomer)
            {
                total = price * 0.8;
                Console.WriteLine($"In Hóa Đơn: {total}"); // Đoạn code trùng lặp
            }
            else
            {
                total = price * 0.95;
                Console.WriteLine($"In Hóa Đơn: {total}"); // Đoạn code trùng lặp
            }
        }
    }
}