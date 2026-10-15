namespace DPM235503_LeThiKimYen_Refactoring42_IntroduceNullObject
{
    public abstract class AbstractCustomer
    {
        public abstract string GetName();
        public abstract bool IsNull();
    }

    public class RealCustomer : AbstractCustomer
    {
        private string _name;
        public RealCustomer(string name) { _name = name; }
        public override string GetName() => _name;
        public override bool IsNull() => false;
    }

    public class NullCustomer : AbstractCustomer
    {
        public override string GetName() => "Khách Lẻ (Chưa Đăng Ký)";
        public override bool IsNull() => true;
    }
}