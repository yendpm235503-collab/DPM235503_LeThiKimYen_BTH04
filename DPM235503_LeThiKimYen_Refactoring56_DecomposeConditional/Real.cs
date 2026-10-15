using System;

namespace DPM235503_LeThiKimYen_Refactoring56_DecomposeConditional
{
    public class RealNongDuocAnGiang
    {
        public double TinhTienXuatKhoVuMua(DateTime ngayGiaoHang, int soLuong)
        {
            if (IsVuMuoichuong(ngayGiaoHang))
            {
                return TinhGiaVuMuoichuong(soLuong);
            }
            return TinhGiaVuChinh(soLuong);
        }

        private bool IsVuMuoichuong(DateTime ngay) => ngay.Month >= 9 && ngay.Month <= 11; // Cao điểm vụ mười chương
        private double TinhGiaVuMuoichuong(int soLuong) => soLuong * 220000; // Giá vụ mười chương
        private double TinhGiaVuChinh(int soLuong) => soLuong * 200000; // Giá chuẩn
    }
}