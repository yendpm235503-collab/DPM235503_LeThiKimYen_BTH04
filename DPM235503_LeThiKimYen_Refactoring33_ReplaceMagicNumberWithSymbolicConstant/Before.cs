namespace DPM235503_LeThiKimYen_Refactoring33_ReplaceMagicNumberWithSymbolicConstant
{
    public class BeforeExample
    {
        public double CalculatePotentialEnergy(double mass, double height)
        {
            // 9.81 là con số ma thuật (Magic Number) không rõ ngữ cảnh
            return mass * 9.81 * height;
        }
    }
}