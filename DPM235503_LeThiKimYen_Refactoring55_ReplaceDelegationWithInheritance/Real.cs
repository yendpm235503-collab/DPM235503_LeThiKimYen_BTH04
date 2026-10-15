namespace DPM235503_LeThiKimYen_Refactoring55_ReplaceDelegationWithInheritance
{
    public class DaiLyAnGiangBase
    {
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
    }

    // Kế thừa trực tiếp vì Đại lý Cấp 1 LÀ Một Đại lý An Giang
    public class DaiLyCap1VIP : DaiLyAnGiangBase
    {
        public double MucChietKhauVIP { get; set; } = 0.15; // 15%
    }
}