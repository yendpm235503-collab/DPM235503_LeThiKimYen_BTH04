using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring49_PushDownField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 49: PUSH DOWN FIELD ===");

            SalesmanAfter sa = new SalesmanAfter { SalesQuota = 50000 };
            Console.WriteLine($"After Sales Quota: {sa.SalesQuota}");

            NhanVienThiTruong nv = new NhanVienThiTruong
            {
                HoTen = "Nguyễn Văn A",
                ChiTieuDoanhSoMoiThang = 200000000
            };
            Console.WriteLine($"[Nông Dược An Giang] NV Thị Trường: {nv.HoTen} - Chỉ tiêu: {nv.ChiTieuDoanhSoMoiThang:N0} VNĐ");

            Console.ReadKey();
        }
    }
}