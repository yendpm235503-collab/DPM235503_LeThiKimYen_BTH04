using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring47_ReplaceExceptionWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 47: REPLACE EXCEPTION WITH TEST ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Value: {before.GetValue(5)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Value: {after.GetValue(5)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double gia = real.TraCuuGiaThuoc("THUOC_DIET_CHUOT");
            Console.WriteLine($"[Nông Dược An Giang] Giá sản phẩm tra cứu: {gia:N0} VNĐ");

            Console.ReadKey();
        }
    }
}