using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring56_DecomposeConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 56: DECOMPOSE CONDITIONAL ===");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Charge: {after.GetCharge(DateTime.Now, 10, 10, 12, 50)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double tongTien = real.TinhTienXuatKhoVuMua(new DateTime(2026, 10, 15), 100);
            Console.WriteLine($"[Nông Dược An Giang] Tổng thành tiền đợt giao hàng tháng 10: {tongTien:N0} VNĐ");

            Console.ReadKey();
        }
    }
}