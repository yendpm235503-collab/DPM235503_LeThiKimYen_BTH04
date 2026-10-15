using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring41_RemoveControlFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 41: REMOVE CONTROL FLAG ===");

            string[] people = { "John", "Don", "Alice" };

            Console.WriteLine("--- BEFORE ---");
            BeforeExample before = new BeforeExample();
            before.CheckSecurity(people);

            Console.WriteLine("--- AFTER ---");
            AfterExample after = new AfterExample();
            after.CheckSecurity(people);

            Console.WriteLine("--- REAL: NÔNG DƯỢC AN GIANG ---");
            string[] dsCam = { "Paraquat", "2,4-D", "Methamidophos" };
            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            bool hopLe = real.KiemTraThuocConHieuLuc(dsCam, "Paraquat");
            Console.WriteLine($"Kết quả kiểm định lưu hành: {hopLe}");

            Console.ReadKey();
        }
    }
}