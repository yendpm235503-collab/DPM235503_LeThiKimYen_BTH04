namespace DPM235503_LeThiKimYen_Refactoring37_ReplaceTypeCodeWithStateStrategy
{
    public abstract class HangThanhVienDaiLy
    {
        public abstract double TinhChietKhau(double tongTienDonHang);
    }

    public class HangDong : HangThanhVienDaiLy
    {
        public override double TinhChietKhau(double tongTienDonHang) => tongTienDonHang * 0.03; // 3%
    }

    public class HangVang : HangThanhVienDaiLy
    {
        public override double TinhChietKhau(double tongTienDonHang) => tongTienDonHang * 0.10; // 10%
    }

    public class DaiLyAnGiangContext
    {
        public string TenDaiLy { get; set; }
        public HangThanhVienDaiLy HangDaiLy { get; set; }

        public double TinhTienKhuyenMai(double tongTien) => HangDaiLy.TinhChietKhau(tongTien);
    }
}