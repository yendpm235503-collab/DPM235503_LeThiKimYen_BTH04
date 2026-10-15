namespace DPM235503_LeThiKimYen_Refactoring38_ReplaceSubclassWithFields
{
    public abstract class PersonBefore
    {
        public abstract bool IsMale();
        public abstract char GetCode();
    }

    public class Male : PersonBefore
    {
        public override bool IsMale() => true;
        public override char GetCode() => 'M';
    }

    public class Female : PersonBefore
    {
        public override bool IsMale() => false;
        public override char GetCode() => 'F';
    }
}