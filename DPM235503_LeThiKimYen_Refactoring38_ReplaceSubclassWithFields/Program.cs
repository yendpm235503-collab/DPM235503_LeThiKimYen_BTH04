using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring38_ReplaceSubclassWithFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 38: REPLACE SUBCLASS WITH FIELDS ===");

            Male mBefore = new Male();
            Console.WriteLine($"Before Code: {mBefore.GetCode()}");

            PersonAfter mAfter = PersonAfter.CreateMale();
            Console.WriteLine($"After Code: {mAfter.GetCode()}");

            QuyCachDongGoiNongDuoc qc = QuyCachDongGoiNongDuoc.Can5Lit();
            Console.WriteLine($"[Nông Dược An Giang] Quy cách đóng gói: {qc.DungTichVang} {qc.DonViTinh}");

            Console.ReadKey();
        }
    }
}