using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring32_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 32: REPLACE DATA VALUE WITH OBJECT ===");

            OrderBefore ob = new OrderBefore("Nguyễn Văn A");
            Console.WriteLine($"Before Customer: {ob.Customer}");

            OrderAfter oa = new OrderAfter("Nguyễn Văn A");
            Console.WriteLine($"After Customer Name: {oa.Customer.Name}");

            DaiLyAnGiang dl = new DaiLyAnGiang("Đại Lý Long Xuyên", "1600999888", "Chợ Mới, An Giang");
            HoaDonNongDuoc hd = new HoaDonNongDuoc("HD001", dl, 45000000);
            Console.WriteLine($"[Nông Dược An Giang] Hóa đơn {hd.MaHoaDon} - Đại lý: {hd.DaiLyThanhToan.TenDaiLy}");

            Console.ReadKey();
        }
    }
}