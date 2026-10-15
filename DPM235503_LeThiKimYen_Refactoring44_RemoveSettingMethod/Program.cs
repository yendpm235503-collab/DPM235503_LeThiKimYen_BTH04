using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring44_RemoveSettingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 44: REMOVE SETTING METHOD ===");

            AccountAfter acc = new AccountAfter("ACC-10023");
            Console.WriteLine($"After Account ID (Read-only): {acc.Id}");

            HoaDonXuatKhoAnGiang hd = new HoaDonXuatKhoAnGiang("HD-AG-2026-001", DateTime.Now)
            {
                TongTien = 25000000
            };
            Console.WriteLine($"[Nông Dược An Giang] Mã HĐ: {hd.MaHoaDon} | Ngày lập: {hd.NgayLap:dd/MM/yyyy} | Tổng: {hd.TongTien:N0} VNĐ");

            Console.ReadKey();
        }
    }
}