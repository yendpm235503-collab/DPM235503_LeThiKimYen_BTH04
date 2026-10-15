using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring57_ChangeValueToReference
{
    public class DaiLyAnGiangRef
    {
        public string TenDaiLy { get; set; }
        public DaiLyAnGiangRef(string ten) { TenDaiLy = ten; }
    }

    public class DaiLyRepository
    {
        private static Dictionary<string, DaiLyAnGiangRef> _list = new Dictionary<string, DaiLyAnGiangRef>();

        public static DaiLyAnGiangRef GetDaiLy(string ten)
        {
            if (!_list.ContainsKey(ten))
                _list[ten] = new DaiLyAnGiangRef(ten);
            return _list[ten];
        }
    }

    public class HoaDonNongDuoc
    {
        public string MaHoaDon { get; set; }
        public DaiLyAnGiangRef DaiLy { get; set; }

        public HoaDonNongDuoc(string maHD, string tenDaiLy)
        {
            MaHoaDon = maHD;
            DaiLy = DaiLyRepository.GetDaiLy(tenDaiLy);
        }
    }
}