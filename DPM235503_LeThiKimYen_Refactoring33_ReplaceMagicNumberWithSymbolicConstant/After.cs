namespace DPM235503_LeThiKimYen_Refactoring33_ReplaceMagicNumberWithSymbolicConstant
{
    public class AfterExample
    {
        // Khai báo hằng số có tên gọi rõ nghĩa
        public const double GRAVITATIONAL_CONSTANT = 9.81;

        public double CalculatePotentialEnergy(double mass, double height)
        {
            return mass * GRAVITATIONAL_CONSTANT * height;
        }
    }
}