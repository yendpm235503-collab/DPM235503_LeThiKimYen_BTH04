namespace DPM235503_LeThiKimYen_Refactoring42_IntroduceNullObject
{
    public abstract class DaiLyBase
    {
        public abstract string TenDaiLy { get; }
        public abstract double ChietKhauAnGiang { get; }
    }

    public class DaiLyChinhThuc : DaiLyBase
    {
        public override string TenDaiLy => "Đại Lý Nông Dược Long Xuyên";
        public override double ChietKhauAnGiang => 0.10; // 10%
    }

    public class DaiLyVangLaiNull : DaiLyBase
    {
        public override string TenDaiLy => "Khách Mua Lẻ Lửa Vụ";
        public override double ChietKhauAnGiang => 0.0; // Không chiết khấu
    }
}