using System;

namespace DPM235503_LeThiKimYen_Refactoring40_ConsolidateDuplicateConditionalFragments
{
    public class RealNongDuocAnGiang
    {
        public void XuatKhoThuocNongNghiep(string tenThuoc, int soLuong, bool giaoTanNoi)
        {
            double cuocPhi;
            if (giaoTanNoi)
            {
                cuocPhi = 150000;
            }
            else
            {
                cuocPhi = 0;
            }

            // Đoạn mã trích xuất chung cho cả 2 trường hợp
            Console.WriteLine($"[XUẤT KHO NÔNG DƯỢC] {tenThuoc} - SL: {soLuong} | Phí giao nhận: {cuocPhi:N0} VNĐ");
            GhiLogHeThong(tenThuoc);
        }

        private void GhiLogHeThong(string tenThuoc)
        {
            Console.WriteLine($"[LOG SYSTEM] Đã lưu lịch sử xuất kho cho '{tenThuoc}'.");
        }
    }
}