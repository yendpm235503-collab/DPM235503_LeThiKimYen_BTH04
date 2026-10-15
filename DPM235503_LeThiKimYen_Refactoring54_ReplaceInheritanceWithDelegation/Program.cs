using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring54_ReplaceInheritanceWithDelegation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 54: REPLACE INHERITANCE WITH DELEGATION ===");

            MyStackAfter stack = new MyStackAfter();
            stack.Push("Phần tử 1");
            Console.WriteLine($"After Stack Count: {stack.Count}");

            DanhSachSanPhamNongDuoc ds = new DanhSachSanPhamNongDuoc();
            ds.ThemThuocMoi("Thuốc Diệt Cỏ An Giang 500ml");
            Console.WriteLine($"[Nông Dược An Giang] Tổng số mặt hàng: {ds.TongSoLuongMatHang}");

            Console.ReadKey();
        }
    }
}