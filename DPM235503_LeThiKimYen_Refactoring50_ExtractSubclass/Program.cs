using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring50_ExtractSubclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 50: EXTRACT SUBCLASS ===");

            LaborItem labor = new LaborItem("John", 50, 8);
            Console.WriteLine($"After Labor Item Total: {labor.GetTotalPrice()}");

            ThuocKiemSoatDacBiet thuocKiemSoat = new ThuocKiemSoatDacBiet
            {
                TenThuoc = "Thuốc Trừ Bệnh Đạo Ôn Đặc Trị",
                DonGia = 350000,
                MaSoGaiPhepLuuHanh = "GP-AG-2026-99"
            };
            thuocKiemSoat.HienThiThongTin();

            Console.ReadKey();
        }
    }
}