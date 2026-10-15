namespace DPM235503_LeThiKimYen_Refactoring35_ReplaceTypeCodeWithClass
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);
        public static readonly BloodGroup B = new BloodGroup(2);

        public int Code { get; private set; }

        public BloodGroup(int code)
        {
            Code = code;
        }
    }

    public class PersonAfter
    {
        public BloodGroup Group { get; set; }

        public PersonAfter(BloodGroup group)
        {
            Group = group;
        }
    }
}