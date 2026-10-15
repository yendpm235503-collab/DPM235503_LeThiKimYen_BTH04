using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring31_SelfEncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 31: SELF ENCAPSULATE FIELD ===");

            BeforeExample before = new BeforeExample(10, 50);
            Console.WriteLine($"Before Includes 25: {before.Includes(25)}");

            AfterExample after = new AfterExample(10, 50);
            Console.WriteLine($"After Includes 25: {after.Includes(25)}");

            GiaThuocNongDuocAnGiang gia = new GiaThuocNongDuocAnGiang(120000);
            Console.WriteLine($"[Nông Dược An Giang] Giá bán lẻ: {gia.TinhGiaBanLeStandard():N0} VNĐ");

            Console.ReadKey();
        }
    }
}