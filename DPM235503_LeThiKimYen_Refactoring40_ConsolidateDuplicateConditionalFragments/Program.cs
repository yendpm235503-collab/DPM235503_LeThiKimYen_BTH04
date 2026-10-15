using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring40_ConsolidateDuplicateConditionalFragments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 40: CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS ===");

            Console.WriteLine("\n--- BEFORE ---");
            BeforeExample before = new BeforeExample();
            before.SendInvoice(true, 100000);

            Console.WriteLine("\n--- AFTER ---");
            AfterExample after = new AfterExample();
            after.SendInvoice(true, 100000);

            Console.WriteLine("\n--- REAL: NÔNG DƯỢC AN GIANG ---");
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            real.XuatKhoThuocNongNghiep("Thuốc Diệt Cỏ An Giang 500ml", 100, true);

            Console.ReadKey();
        }
    }
}