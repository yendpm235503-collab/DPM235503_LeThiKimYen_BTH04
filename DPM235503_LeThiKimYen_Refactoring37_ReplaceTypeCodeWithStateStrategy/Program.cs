using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring37_ReplaceTypeCodeWithStateStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 37: REPLACE TYPE CODE WITH STATE/STRATEGY ===");

            EmployeeBefore eb = new EmployeeBefore { Type = EmployeeBefore.ENGINEER };
            Console.WriteLine($"Before Pay: {eb.GetPay(1000)}");

            EmployeeAfter ea = new EmployeeAfter { Type = new EngineerType() };
            Console.WriteLine($"After Pay: {ea.GetPay(1000)}");

            DaiLyAnGiangContext daily = new DaiLyAnGiangContext
            {
                TenDaiLy = "Đại Lý Mười Giàu (An Giang)",
                HangDaiLy = new HangVang() // Thay đổi hạng thành viên động
            };
            Console.WriteLine($"[Nông Dược An Giang] Chiết khấu Hạng Vàng: {daily.TinhTienKhuyenMai(50000000):N0} VNĐ");

            Console.ReadKey();
        }
    }
}