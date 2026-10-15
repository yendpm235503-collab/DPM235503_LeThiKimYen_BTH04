using System;
using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring54_ReplaceInheritanceWithDelegation
{
    public class DanhSachSanPhamNongDuoc
    {
        private readonly List<string> _dsThuoc = new List<string>();

        public void ThemThuocMoi(string tenThuoc)
        {
            _dsThuoc.Add(tenThuoc);
            Console.WriteLine($"[KHO AN GIANG] Đã thêm sản phẩm: {tenThuoc}");
        }

        public int TongSoLuongMatHang => _dsThuoc.Count;
    }
}