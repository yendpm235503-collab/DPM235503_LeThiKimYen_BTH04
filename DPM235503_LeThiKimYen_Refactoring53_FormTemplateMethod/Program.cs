using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring53_FormTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 53: FORM TEMPLATE METHOD ===");

            StatementAfter stmt = new TextStatementAfter();
            stmt.Print();

            Console.WriteLine("\n--- REAL: QUY TRÌNH XUẤT KHO NÔNG DƯỢC ---");
            QuyTrinhXuatKhoCoBan quyTrinh = new XuatKhoThuocTruSau();
            quyTrinh.ThucHienXuatKho();

            Console.ReadKey();
        }
    }
}