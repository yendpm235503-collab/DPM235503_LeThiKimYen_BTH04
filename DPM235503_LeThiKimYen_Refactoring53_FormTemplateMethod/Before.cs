using System;

namespace DPM235503_LeThiKimYen_Refactoring53_FormTemplateMethod
{
    public class TextStatement
    {
        public void Print()
        {
            Console.WriteLine("=== HEADER TEXT ===");
            Console.WriteLine("Content Text");
            Console.WriteLine("=== FOOTER TEXT ===");
        }
    }

    public class HtmlStatement
    {
        public void Print()
        {
            Console.WriteLine("<h1>HEADER HTML</h1>");
            Console.WriteLine("<p>Content HTML</p>");
            Console.WriteLine("<footer>FOOTER HTML</footer>");
        }
    }
}