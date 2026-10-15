using System;

namespace DPM235503_LeThiKimYen_Refactoring53_FormTemplateMethod
{
    public abstract class StatementAfter
    {
        public void Print() // Template Method
        {
            PrintHeader();
            PrintContent();
            PrintFooter();
        }

        protected abstract void PrintHeader();
        protected abstract void PrintContent();
        protected abstract void PrintFooter();
    }

    public class TextStatementAfter : StatementAfter
    {
        protected override void PrintHeader() => Console.WriteLine("=== HEADER TEXT ===");
        protected override void PrintContent() => Console.WriteLine("Content Text");
        protected override void PrintFooter() => Console.WriteLine("=== FOOTER TEXT ===");
    }
}