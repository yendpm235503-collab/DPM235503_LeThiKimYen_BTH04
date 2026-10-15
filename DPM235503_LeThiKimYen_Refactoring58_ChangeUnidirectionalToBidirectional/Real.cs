using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring58_ChangeUnidirectionalToBidirectional
{
    public class DaiLyAnGiangBi
    {
        public string TenDaiLy { get; set; }
        public List<PhieuXuatKhoBi> DanhSachPhieuXuat { get; } = new List<PhieuXuatKhoBi>();
    }

    public class PhieuXuatKhoBi
    {
        public string MaPhieu { get; set; }
        private DaiLyAnGiangBi _daiLy;

        public DaiLyAnGiangBi DaiLy
        {
            get => _daiLy;
            set
            {
                _daiLy?.DanhSachPhieuXuat.Remove(this);
                _daiLy = value;
                _daiLy?.DanhSachPhieuXuat.Add(this);
            }
        }
    }
}