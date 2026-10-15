using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring34_EncapsulateCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 34: ENCAPSULATE COLLECTION ===");

            CourseAfter course = new CourseAfter();
            course.AddStudent("Yến");
            Console.WriteLine($"Số học viên: {course.Students.Count}");

            KhoNongDuocAnGiang kho = new KhoNongDuocAnGiang();
            kho.NhapKho("Thuốc Diệt Cỏ An Giang 500ml");
            kho.NhapKho("Phân Bón NPK 50kg");
            Console.WriteLine($"Tổng mặt hàng tồn kho: {kho.DanhSachThuoc.Count}");

            Console.ReadKey();
        }
    }
}