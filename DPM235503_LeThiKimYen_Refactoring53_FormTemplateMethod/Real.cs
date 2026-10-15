using System;

namespace DPM235503_LeThiKimYen_Refactoring53_FormTemplateMethod
{
    public abstract class QuyTrinhXuatKhoCoBan
    {
        public void ThucHienXuatKho()
        {
            KiemTraTonKho();
            XuatHang();
            LuuLichSu();
        }

        protected abstract void KiemTraTonKho();
        protected abstract void XuatHang();
        private void LuuLichSu() => Console.WriteLine("[HỆ THỐNG] Đã lưu nhật ký xuất kho thành công.");
    }

    public class XuatKhoThuocTruSau : QuyTrinhXuatKhoCoBan
    {
        protected override void KiemTraTonKho() => Console.WriteLine("1. Kiểm tra tem kiểm định độc hại & số lượng chai.");
        protected override void XuatHang() => Console.WriteLine("2. Đóng thùng gỗ vận chuyển Thuốc Trừ Sâu An Giang.");
    }
}