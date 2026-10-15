namespace DPM235503_LeThiKimYen_Refactoring49_PushDownField
{
    public abstract class NhanVienAnGiangBase
    {
        public string HoTen { get; set; }
    }

    public class NhanVienThiTruong : NhanVienAnGiangBase
    {
        // Thuộc tính Chỉ tiêu doanh số chỉ riêng Nhân viên Thị trường có
        public double ChiTieuDoanhSoMoiThang { get; set; }
    }

    public class NhanVienKyThuat : NhanVienAnGiangBase
    {
        public int SoDotKiemDinhDongKieu { get; set; }
    }
}