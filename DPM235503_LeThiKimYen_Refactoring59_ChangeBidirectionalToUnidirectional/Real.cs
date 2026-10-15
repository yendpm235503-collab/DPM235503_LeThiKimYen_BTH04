namespace DPM235503_LeThiKimYen_Refactoring59_ChangeBidirectionalToUnidirectional
{
    public class KhoHangAnGiang
    {
        public string TenKho { get; set; } = "Kho Trung Tâm Long Xuyên";
    }

    public class PhieuXuatThuoc
    {
        public string MaPhieu { get; set; }
        // Phất xuất kho trỏ đến Kho, Kho không cần duy trì danh sách phiếu thừa thãi
        public KhoHangAnGiang KhoXuat { get; set; }
    }
}