using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring46_ReplaceErrorCodeWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 46: REPLACE ERROR CODE WITH EXCEPTION ===");

            AccountBefore before = new AccountBefore();
            int res = before.Withdraw(1000);
            Console.WriteLine($"Before Withdraw Status Code: {res}");

            AccountAfter after = new AccountAfter();
            try
            {
                after.Withdraw(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"After Caught Exception: {ex.Message}");
            }

            KhoThuocAnGiang kho = new KhoThuocAnGiang();
            try
            {
                kho.XuatKhoThuocTruSau(50);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Nông Dược An Giang Error] {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}