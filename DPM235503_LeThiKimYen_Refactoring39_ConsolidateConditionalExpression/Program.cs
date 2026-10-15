using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring39_ConsolidateConditionalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 39: CONSOLIDATE CONDITIONAL EXPRESSION ===");

            BeforeExample before = new BeforeExample();
            Console.WriteLine($"Before Amount: {before.DisabilityAmount(1, 5, false)}");

            AfterExample after = new AfterExample();
            Console.WriteLine($"After Amount: {after.DisabilityAmount(1, 5, false)}");

            RealNongDuocAnGiang real = new RealNongDuocAnGiang();
            bool duocChoNo = real.KiemTraChoDaiLyNoGoiVudong(1, 20000000, false);
            Console.WriteLine($"[Nông Dược An Giang] Cho phép Đại lý nợ gối vụ: {duocChoNo}");

            Console.ReadKey();
        }
    }
}