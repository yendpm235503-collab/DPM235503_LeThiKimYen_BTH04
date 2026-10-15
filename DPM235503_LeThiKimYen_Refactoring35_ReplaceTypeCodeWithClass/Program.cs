using System;
using System.Text;

namespace DPM235503_LeThiKimYen_Refactoring35_ReplaceTypeCodeWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== REFACTORING 35: REPLACE TYPE CODE WITH CLASS ===");

            PersonBefore pb = new PersonBefore(PersonBefore.A);
            Console.WriteLine($"Before Blood Code: {pb.BloodGroupCode}");

            PersonAfter pa = new PersonAfter(BloodGroup.A);
            Console.WriteLine($"After Blood Code: {pa.Group.Code}");

            SanPhamAnGiang sp = new SanPhamAnGiang("Phân Bón NPK 20-20-15", LoaiVatTuNongNghiep.PhanBon);
            Console.WriteLine($"[Nông Dược An Giang] Sản phẩm {sp.TenSanPham} thuộc nhóm: {sp.LoaiVatTu.TenLoai}");

            Console.ReadKey();
        }
    }
}