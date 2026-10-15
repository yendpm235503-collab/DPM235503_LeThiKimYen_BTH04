using System;
using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring34_EncapsulateCollection
{
    public class KhoNongDuocAnGiang
    {
        private readonly List<string> _dsThuocTrongKho = new List<string>();

        public IReadOnlyCollection<string> DanhSachThuoc => _dsThuocTrongKho.AsReadOnly();

        public void NhapKho(string tenThuoc)
        {
            _dsThuocTrongKho.Add(tenThuoc);
            Console.WriteLine($"[NHẬP KHO] Đã nhập: {tenThuoc}");
        }

        public void XuatKho(string tenThuoc)
        {
            if (_dsThuocTrongKho.Remove(tenThuoc))
            {
                Console.WriteLine($"[XUẤT KHO] Đã xuất: {tenThuoc}");
            }
        }
    }
}