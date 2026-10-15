namespace DPM235503_LeThiKimYen_Refactoring33_ReplaceMagicNumberWithSymbolicConstant
{
    public class RealNongDuocAnGiang
    {
        private const double TY_LE_VAT_NONG_NGHIEP = 0.05; // 5% thuế VAT vật tư
        private const double MUC_CHIET_KHAU_DAI_LY_CAP_1 = 0.12; // 12% chiết khấu

        public double TinhThanhToanDonHang(double giaTienGoc, bool isDaiLyCap1)
        {
            double tienThue = giaTienGoc * TY_LE_VAT_NONG_NGHIEP;
            double tienChietKhau = isDaiLyCap1 ? giaTienGoc * MUC_CHIET_KHAU_DAI_LY_CAP_1 : 0;
            return giaTienGoc + tienThue - tienChietKhau;
        }
    }
}