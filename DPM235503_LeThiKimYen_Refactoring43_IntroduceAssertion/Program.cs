using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring43_IntroduceAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 43: INTRODUCE ASSERTION ===");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Expense Limit: {after.GetExpenseLimit()}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double tongTien = real.TinhThanhTien(180000, 50);
            Console.WriteLine($"[Nông Dược An Giang] Tổng tiền xuất hàng: {tongTien:N0} VNĐ");

            Console.ReadKey();
        }
    }
}