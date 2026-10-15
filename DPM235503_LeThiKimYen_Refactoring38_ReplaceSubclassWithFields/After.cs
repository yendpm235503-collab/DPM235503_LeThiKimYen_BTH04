namespace DPM235503_LeThiKimYen_Refactoring38_ReplaceSubclassWithFields
{
    public class PersonAfter
    {
        private readonly bool _isMale;
        private readonly char _code;

        public PersonAfter(bool isMale, char code)
        {
            _isMale = isMale;
            _code = code;
        }

        public bool IsMale() => _isMale;
        public char GetCode() => _code;

        public static PersonAfter CreateMale() => new PersonAfter(true, 'M');
        public static PersonAfter CreateFemale() => new PersonAfter(false, 'F');
    }
}