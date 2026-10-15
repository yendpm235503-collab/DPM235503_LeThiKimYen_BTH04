namespace DPM235503_LeThiKimYen_Refactoring32_ReplaceDataValueWithObject
{
    public class DaiLyAnGiang
    {
        public string TenDaiLy { get; set; }
        public string MaSoThue { get; set; }
        public string DiaChi { get; set; }

        public DaiLyAnGiang(string ten, string mst, string diaChi)
        {
            TenDaiLy = ten;
            MaSoThue = mst;
            DiaChi = diaChi;
        }
    }

    public class HoaDonNongDuoc
    {
        public string MaHoaDon { get; set; }
        public DaiLyAnGiang DaiLyThanhToan { get; set; }
        public double TongTien { get; set; }

        public HoaDonNongDuoc(string maHD, DaiLyAnGiang daiLy, double tongTien)
        {
            MaHoaDon = maHD;
            DaiLyThanhToan = daiLy;
            TongTien = tongTien;
        }
    }
}