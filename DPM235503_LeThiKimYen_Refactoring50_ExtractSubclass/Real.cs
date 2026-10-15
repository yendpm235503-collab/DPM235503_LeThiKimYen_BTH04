using System;

namespace DPM235503_LeThiKimYen_Refactoring50_ExtractSubclass
{
    public class SanPhamNongDuocStandard
    {
        public string TenThuoc { get; set; }
        public double DonGia { get; set; }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"[SẢN PHẨM PHỔ THÔNG] {TenThuoc} - Giá: {DonGia:N0} VNĐ");
        }
    }

    // Tách Lớp con cho nhóm Thuốc bảo vệ thực vật cần kiểm soát đặc biệt
    public class ThuocKiemSoatDacBiet : SanPhamNongDuocStandard
    {
        public string MaSoGaiPhepLuuHanh { get; set; }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"[SẢN PHẨM ĐẶC BIỆT] {TenThuoc} - Giá: {DonGia:N0} VNĐ | Giấy phép lưu hành: {MaSoGaiPhepLuuHanh}");
        }
    }
}