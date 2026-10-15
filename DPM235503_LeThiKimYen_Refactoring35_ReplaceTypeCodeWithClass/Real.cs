namespace DPM235503_LeThiKimYen_Refactoring35_ReplaceTypeCodeWithClass
{
    public class LoaiVatTuNongNghiep
    {
        public static readonly LoaiVatTuNongNghiep ThuocTruSau = new LoaiVatTuNongNghiep(101, "Thuốc Trừ Sâu");
        public static readonly LoaiVatTuNongNghiep PhanBon = new LoaiVatTuNongNghiep(102, "Phân Bón Hóa Học");

        public int MaLoai { get; private set; }
        public string TenLoai { get; private set; }

        public LoaiVatTuNongNghiep(int ma, string ten)
        {
            MaLoai = ma;
            TenLoai = ten;
        }
    }

    public class SanPhamAnGiang
    {
        public string TenSanPham { get; set; }
        public LoaiVatTuNongNghiep LoaiVatTu { get; set; }

        public SanPhamAnGiang(string ten, LoaiVatTuNongNghiep loai)
        {
            TenSanPham = ten;
            LoaiVatTu = loai;
        }
    }
}