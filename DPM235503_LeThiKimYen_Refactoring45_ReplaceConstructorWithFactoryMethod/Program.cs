using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring45_ReplaceConstructorWithFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 45: REPLACE CONSTRUCTOR WITH FACTORY METHOD ===");

            EmployeeAfter mgr = EmployeeAfter.CreateManager();
            Console.WriteLine($"After Employee Type: {mgr.Type}");

            SanPhamNongDuoc sp1 = SanPhamNongDuoc.TaoThuocTruSau("Thuốc Trừ Sâu An Giang 250ml", 120000);
            SanPhamNongDuoc sp2 = SanPhamNongDuoc.TaoPhanBonLa("Phân Bón Lá NPK 1L", 85000);

            Console.WriteLine($"[Nông Dược An Giang] {sp1.TenSanPham} | Loại: {sp1.Loai} | Giá: {sp1.DonGia:N0} VNĐ");
            Console.WriteLine($"[Nông Dược An Giang] {sp2.TenSanPham} | Loại: {sp2.Loai} | Giá: {sp2.DonGia:N0} VNĐ");

            Console.ReadKey();
        }
    }
}