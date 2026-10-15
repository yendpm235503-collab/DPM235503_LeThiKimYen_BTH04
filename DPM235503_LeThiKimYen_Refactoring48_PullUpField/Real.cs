namespace DPM235503_LeThiKimYen_Refactoring48_PullUpField
{
    public abstract class VatTuNongNghiepBase
    {
        // Thuộc tính dùng chung được kéo lên lớp cha
        public string TenSanPham { get; set; }
        public double GiaXuatKho { get; set; }
    }

    public class ThuocTruSauAnGiang : VatTuNongNghiepBase
    {
        public string ThanhPhanHoaHoc { get; set; }
    }

    public class PhanBonSinhHocAnGiang : VatTuNongNghiepBase
    {
        public double TyLeHuuCo { get; set; }
    }
}