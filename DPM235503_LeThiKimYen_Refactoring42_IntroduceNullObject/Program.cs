using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring42_IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 42: INTRODUCE NULL OBJECT ===");

            AbstractCustomer c1 = new RealCustomer("Lê Thị Kim Yến");
            AbstractCustomer c2 = new NullCustomer();

            Console.WriteLine($"Customer 1: {c1.GetName()}");
            Console.WriteLine($"Customer 2 (Null Object): {c2.GetName()}");

            DaiLyBase daily = new DaiLyVangLaiNull();
            Console.WriteLine($"[Nông Dược An Giang] Loại đối tác: {daily.TenDaiLy} | Chiết khấu: {daily.ChietKhauAnGiang * 100}%");

            Console.ReadKey();
        }
    }
}