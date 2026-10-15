using System;

namespace DPM235503_LeThiKimYen_Refactoring31_SelfEncapsulateField
{
    public class GiaThuocNongDuocAnGiang
    {
        private double _giaNhap;

        public double GiaNhap
        {
            get => _giaNhap;
            set
            {
                if (value < 0) _giaNhap = 0;
                else _giaNhap = value;
            }
        }

        public GiaThuocNongDuocAnGiang(double gia)
        {
            GiaNhap = gia; // Tự đóng gói qua Property để bảo đảm ràng buộc > 0
        }

        public double TinhGiaBanLeStandard()
        {
            return GiaNhap * 1.15;
        }
    }
}