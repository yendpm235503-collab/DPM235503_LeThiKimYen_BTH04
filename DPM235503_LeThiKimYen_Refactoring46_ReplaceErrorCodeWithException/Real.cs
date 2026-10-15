using System;

namespace DPM235503_LeThiKimYen_Refactoring46_ReplaceErrorCodeWithException
{
    public class KhoThuocAnGiang
    {
        private int _soLuongTon = 20;

        public void XuatKhoThuocTruSau(int soLuongYeuCau)
        {
            if (soLuongYeuCau > _soLuongTon)
            {
                throw new InvalidOperationException($"Kho Nông Dược An Giang không đủ hàng! Tồn kho hiện tại: {_soLuongTon}, Yêu cầu: {soLuongYeuCau}");
            }
            _soLuongTon -= soLuongYeuCau;
        }

        public int GetSoLuongTon() => _soLuongTon;
    }
}