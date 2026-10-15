using System;
using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring47_ReplaceExceptionWithTest
{
    public class RealNongDuocAnGiang
    {
        private Dictionary<string, double> _bangGiaThuoc = new Dictionary<string, double>
        {
            { "THUOC_DIET_CO", 120000 },
            { "PHAN_BON_NPK", 450000 }
        };

        // Kiểm tra Key bằng ContainsKey thay vì catch KeyNotFoundException
        public double TraCuuGiaThuoc(string maThuoc)
        {
            if (!_bangGiaThuoc.ContainsKey(maThuoc))
            {
                Console.WriteLine($"[CẢNH BÁO] Không tìm thấy mã sản phẩm '{maThuoc}' trong hệ thống!");
                return 0;
            }
            return _bangGiaThuoc[maThuoc];
        }
    }
}