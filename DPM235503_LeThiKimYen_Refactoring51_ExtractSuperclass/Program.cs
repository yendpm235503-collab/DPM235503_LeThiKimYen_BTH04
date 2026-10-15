using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring51_ExtractSuperclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 51: EXTRACT SUPERCLASS ===");

            PartyAfter dept = new DepartmentAfter { Name = "Phòng Kinh Doanh", AnnualCost = 500000 };
            Console.WriteLine($"After Dept Annual Cost: {dept.GetAnnualCost():N0}");

            DoiTacKinhDoanhBase daily = new DaiLyCap1AnGiang { TenDoiTac = "Đại Lý Long Xuyên", DoanhSoThang = 150000000 };
            Console.WriteLine($"[Nông Dược An Giang] Doanh số tháng đối tác '{daily.TenDoiTac}': {daily.TinhGiaTriGiaoDichThang():N0} VNĐ");

            Console.ReadKey();
        }
    }
}