using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring60_DuplicateObservedData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 60: DUPLICATE OBSERVED DATA ===");

            FormUIAfter ui = new FormUIAfter();
            ui.SetStart(100);

            Console.WriteLine("\n--- REAL: GIAO DIỆN XUẤT KHO NÔNG DƯỢC AN GIANG ---");
            ManHinhXuatKhoForm form = new ManHinhXuatKhoForm();
            form.NhapGiaTriMoi(75000000);

            Console.ReadKey();
        }
    }
}