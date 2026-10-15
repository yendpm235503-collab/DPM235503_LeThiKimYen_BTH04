namespace DPM235503_LeThiKimYen_Refactoring35_ReplaceTypeCodeWithClass
{
    public class PersonBefore
    {
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;

        public int BloodGroupCode { get; set; }

        public PersonBefore(int bloodGroupCode)
        {
            BloodGroupCode = bloodGroupCode;
        }
    }
}