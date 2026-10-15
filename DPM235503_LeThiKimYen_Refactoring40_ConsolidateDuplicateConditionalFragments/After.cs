using System;

namespace DPM235503_LeThiKimYen_Refactoring40_ConsolidateDuplicateConditionalFragments
{
    public class AfterExample
    {
        public void SendInvoice(bool isSpecialCustomer, double price)
        {
            double total;
            if (isSpecialCustomer)
            {
                total = price * 0.8;
            }
            else
            {
                total = price * 0.95;
            }

            // Đưa dòng code chung ra ngoài khối if-else
            Console.WriteLine($"In Hóa Đơn: {total}");
        }
    }
}