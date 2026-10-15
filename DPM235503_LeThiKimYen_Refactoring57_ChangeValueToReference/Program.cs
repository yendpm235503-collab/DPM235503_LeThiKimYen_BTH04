using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring57_ChangeValueToReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 57: CHANGE VALUE TO REFERENCE ===");

            OrderAfter o1 = new OrderAfter("Đại Lý Long Xuyên");
            OrderAfter o2 = new OrderAfter("Đại Lý Long Xuyên");
            Console.WriteLine($"Is Same Reference: {object.ReferenceEquals(o1.Customer, o2.Customer)}");

            HoaDonNongDuoc hd1 = new HoaDonNongDuoc("HD01", "Đại Lý VTNN An Giang");
            HoaDonNongDuoc hd2 = new HoaDonNongDuoc("HD02", "Đại Lý VTNN An Giang");
            Console.WriteLine($"[Nông Dược An Giang] Cùng tham chiếu đối tượng Đại lý: {object.ReferenceEquals(hd1.DaiLy, hd2.DaiLy)}");

            Console.ReadKey();
        }
    }
}