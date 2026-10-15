using System;

namespace DPM235503_LeThiKimYen_Refactoring52_CollapseHierarchy
{
    public class PhanBonAnGiang
    {
        public string TenPhanBon { get; set; }
        public double GiaThung { get; set; }
        public bool LaPhanBonLaSinhHoc { get; set; }

        public void InThongTin()
        {
            string loai = LaPhanBonLaSinhHoc ? "Phân Bón Lá Sinh Học" : "Phân Bón Hóa Học";
            Console.WriteLine($"[NÔNG DƯỢC AN GIANG] {TenPhanBon} ({loai}) - Giá: {GiaThung:N0} VNĐ/thùng");
        }
    }
}