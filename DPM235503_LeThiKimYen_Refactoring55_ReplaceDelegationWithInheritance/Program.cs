using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring55_ReplaceDelegationWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 55: REPLACE DELEGATION WITH INHERITANCE ===");

            EmployeeAfter emp = new EmployeeAfter { Name = "Lê Thị Kim Yến" };
            Console.WriteLine($"After Employee Name: {emp.Name}");

            DaiLyCap1VIP daily = new DaiLyCap1VIP
            {
                TenDaiLy = "Đại Lý Long Xuyên",
                DiaChi = "TP. Long Xuyên, An Giang"
            };
            Console.WriteLine($"[Nông Dược An Giang] {daily.TenDaiLy} | Địa chỉ: {daily.DiaChi} | Mức chiết khấu: {daily.MucChietKhauVIP * 100}%");

            Console.ReadKey();
        }
    }
}