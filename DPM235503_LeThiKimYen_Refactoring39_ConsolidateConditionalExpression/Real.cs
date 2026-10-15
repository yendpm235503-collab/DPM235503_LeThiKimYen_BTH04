namespace DPM235503_LeThiKimYen_Refactoring39_ConsolidateConditionalExpression
{
    public class RealNongDuocAnGiang
    {
        public bool KiemTraChoDaiLyNoGoiVudong(int soThangQuaHan, double noCuPhatSinh, bool biCanhBaoTinDung)
        {
            // Gộp gộp chung toàn bộ điều kiện TỪ CHỐI nợ gối vụ
            if (soThangQuaHan > 3 || noCuPhatSinh > 50000000 || biCanhBaoTinDung)
            {
                return false; // Không cho nợ gối vụ
            }
            return true; // Cho phép mua nợ gối vụ
        }
    }
}