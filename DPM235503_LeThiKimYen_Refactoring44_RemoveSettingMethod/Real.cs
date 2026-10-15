using System;

namespace DPM235503_LeThiKimYen_Refactoring44_RemoveSettingMethod
{
    public class HoaDonXuatKhoAnGiang
    {
        // Mã hóa đơn và Ngày lập là bất biến (Read-only)
        public string MaHoaDon { get; }
        public DateTime NgayLap { get; }
        public double TongTien { get; set; }

        public HoaDonXuatKhoAnGiang(string maHD, DateTime ngayLap)
        {
            MaHoaDon = maHD;
            NgayLap = ngayLap;
        }
    }
}