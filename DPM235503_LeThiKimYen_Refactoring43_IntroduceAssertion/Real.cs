using System;
using System.Diagnostics;

namespace DPM235503_LeThiKimYen_Refactoring43_IntroduceAssertion
{
    public class RealNongDuocAnGiang
    {
        public double TinhThanhTien(double donGia, int soLuong)
        {
            Debug.Assert(donGia > 0, "Đơn giá sản phẩm nông dược phải lớn hơn 0");
            Debug.Assert(soLuong > 0, "Số lượng xuất kho phải lớn hơn 0");

            return donGia * soLuong;
        }
    }
}