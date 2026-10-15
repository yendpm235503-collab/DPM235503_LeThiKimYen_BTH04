using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring36_ReplaceTypeCodeWithSubclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 36: REPLACE TYPE CODE WITH SUBCLASSES ===");

            EmployeeBefore eb = new EmployeeBefore(EmployeeBefore.SALESMAN);
            Console.WriteLine($"Before Salary: {eb.GetMonthlySalary(5000)}");

            EmployeeAfter ea = new Salesman();
            Console.WriteLine($"After Salary: {ea.GetMonthlySalary(5000)}");

            NhanVienNongDuoc nv = new NhanVienThiTruong { HoTen = "Lê Văn Tấn" };
            Console.WriteLine($"[Nông Dược An Giang] Thưởng NV Thị trường ({nv.HoTen}): {nv.TinhPhuCapThuong(10000000):N0} VNĐ");

            Console.ReadKey();
        }
    }
}