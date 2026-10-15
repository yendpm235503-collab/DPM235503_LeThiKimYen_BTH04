using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring33_ReplaceMagicNumberWithSymbolicConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 33: REPLACE MAGIC NUMBER WITH SYMBOLIC CONSTANT ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Energy: {before.CalculatePotentialEnergy(10, 5)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Energy: {after.CalculatePotentialEnergy(10, 5)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            double tongTien = real.TinhThanhToanDonHang(100000000, true);
            Console.WriteLine($"[Nông Dược An Giang] Tổng tiền đơn hàng có chiết khấu: {tongTien:N0} VNĐ");

            Console.ReadKey();
        }
    }
}