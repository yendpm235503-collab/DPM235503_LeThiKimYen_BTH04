using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring48_PullUpField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 48: PULL UP FIELD ===");

            SalesmanAfter sa = new SalesmanAfter { Name = "Lê Văn Tấn" };
            Console.WriteLine($"After Employee Name: {sa.Name}");

            ThuocTruSauAnGiang thuoc = new ThuocTruSauAnGiang
            {
                TenSanPham = "Thuốc Trừ Sâu An Giang 250ml",
                GiaXuatKho = 120000,
                ThanhPhanHoaHoc = "Permethrin 50%"
            };
            Console.WriteLine($"[Nông Dược An Giang] Sản phẩm: {thuoc.TenSanPham} | Giá: {thuoc.GiaXuatKho:N0} VNĐ");

            Console.ReadKey();
        }
    }
}