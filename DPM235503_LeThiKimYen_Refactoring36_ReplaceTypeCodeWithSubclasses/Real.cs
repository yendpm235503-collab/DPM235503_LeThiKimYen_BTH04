namespace DPM235503_LeThiKimYen_Refactoring36_ReplaceTypeCodeWithSubclasses
{
    public abstract class NhanVienNongDuoc
    {
        public string HoTen { get; set; }
        public abstract double TinhPhuCapThuong(double luongCoBan);
    }

    public class NhanVienThiTruong : NhanVienNongDuoc
    {
        public override double TinhPhuCapThuong(double luongCoBan) => luongCoBan * 0.25; // Phụ cấp xăng xe & thị trường
    }

    public class NhanVienKhoAnGiang : NhanVienNongDuoc
    {
        public override double TinhPhuCapThuong(double luongCoBan) => luongCoBan * 0.15; // Phụ cấp bốc xếp & độc hại
    }
}