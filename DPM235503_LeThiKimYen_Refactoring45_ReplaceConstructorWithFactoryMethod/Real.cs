using System;

namespace DPM235503_LeThiKimYen_Refactoring45_ReplaceConstructorWithFactoryMethod
{
    public class SanPhamNongDuoc
    {
        public string TenSanPham { get; private set; }
        public string Loai { get; private set; }
        public double DonGia { get; private set; }

        private SanPhamNongDuoc(string ten, string loai, double donGia)
        {
            TenSanPham = ten;
            Loai = loai;
            DonGia = donGia;
        }

        public static SanPhamNongDuoc TaoThuocTruSau(string ten, double gia)
        {
            return new SanPhamNongDuoc(ten, "Thuốc Trừ Sâu - Độc tính Cấp II", gia);
        }

        public static SanPhamNongDuoc TaoPhanBonLa(string ten, double gia)
        {
            return new SanPhamNongDuoc(ten, "Phân Bón Lá Sinh Học", gia);
        }
    }
}