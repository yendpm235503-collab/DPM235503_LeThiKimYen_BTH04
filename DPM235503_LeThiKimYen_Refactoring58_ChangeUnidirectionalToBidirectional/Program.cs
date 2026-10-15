using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring58_ChangeUnidirectionalToBidirectional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 58: CHANGE UNIDIRECTIONAL TO BIDIRECTIONAL ===");

            CustomerAfter cust = new CustomerAfter();
            OrderAfter ord = new OrderAfter { Customer = cust };
            Console.WriteLine($"Customer Orders Count: {cust.Orders.Count}");

            DaiLyAnGiangBi daily = new DaiLyAnGiangBi { TenDaiLy = "Đại Lý Châu Thành" };
            PhieuXuatKhoBi px = new PhieuXuatKhoBi { MaPhieu = "PX-2026-001", DaiLy = daily };
            Console.WriteLine($"[Nông Dược An Giang] Số phiếu xuất liên kết từ Đại lý: {daily.DanhSachPhieuXuat.Count}");

            Console.ReadKey();
        }
    }
}