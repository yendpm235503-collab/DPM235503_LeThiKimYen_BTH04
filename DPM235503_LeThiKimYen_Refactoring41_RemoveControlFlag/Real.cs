using System;

namespace DPM235503_LeThiKimYen_Refactoring41_RemoveControlFlag
{
    public class RealNongDuocAnGiang
    {
        public bool KiemTraThuocConHieuLuc(string[] dsThuocCấm, string tenThuocCanKiemTra)
        {
            foreach (var thuoc in dsThuocCấm)
            {
                if (thuoc.Equals(tenThuocCanKiemTra, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"[CẢNH BÁO] Thuốc '{tenThuocCanKiemTra}' nằm trong danh mục cấm lưu hành!");
                    return false; // Trả về ngay khi phát hiện vi phạm
                }
            }
            return true;
        }
    }
}