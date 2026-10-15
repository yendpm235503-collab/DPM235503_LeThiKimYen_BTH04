using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring52_CollapseHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 52: COLLAPSE HIERARCHY ===");

            EmployeeAfter emp = new EmployeeAfter { Name = "Lê Thị Kim Yến", IsSalesman = true };
            Console.WriteLine($"After Employee: {emp.Name} (IsSalesman: {emp.IsSalesman})");

            PhanBonAnGiang pb = new PhanBonAnGiang { TenPhanBon = "Phân Bón NPK 20-20-15", GiaThung = 450000, LaPhanBonLaSinhHoc = false };
            pb.InThongTin();

            Console.ReadKey();
        }
    }
}