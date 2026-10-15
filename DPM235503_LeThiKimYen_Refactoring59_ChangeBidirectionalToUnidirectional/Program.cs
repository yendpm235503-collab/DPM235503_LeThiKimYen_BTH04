using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring59_ChangeBidirectionalToUnidirectional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 59: CHANGE BIDIRECTIONAL TO UNIDIRECTIONAL ===");

            OrderAfter ord = new OrderAfter { Customer = new CustomerAfter() };
            Console.WriteLine($"After Order Has Customer: {ord.Customer != null}");

            PhieuXuatThuoc px = new PhieuXuatThuoc { MaPhieu = "PX-01", KhoXuat = new KhoHangAnGiang() };
            Console.WriteLine($"[Nông Dược An Giang] Phiếu {px.MaPhieu} xuất tại: {px.KhoXuat.TenKho}");

            Console.ReadKey();
        }
    }
}