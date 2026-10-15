namespace DPM235503_LeThiKimYen_Refactoring51_ExtractSuperclass
{
    public abstract class DoiTacKinhDoanhBase
    {
        public string TenDoiTac { get; set; }
        public string MaSoThue { get; set; }
        public abstract double TinhGiaTriGiaoDichThang();
    }

    public class DaiLyCap1AnGiang : DoiTacKinhDoanhBase
    {
        public double DoanhSoThang { get; set; }
        public override double TinhGiaTriGiaoDichThang() => DoanhSoThang;
    }

    public class NhaCungCapNguyenLieu : DoiTacKinhDoanhBase
    {
        public double GiaTriLôHangNhap { get; set; }
        public override double TinhGiaTriGiaoDichThang() => GiaTriLôHangNhap;
    }
}