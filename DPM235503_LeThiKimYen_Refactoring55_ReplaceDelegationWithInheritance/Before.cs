namespace DPM235503_LeThiKimYen_Refactoring55_ReplaceDelegationWithInheritance
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class EmployeeBefore
    {
        private Person _person = new Person(); // Ủy quyền dư thừa

        public string Name
        {
            get => _person.Name;
            set => _person.Name = value;
        }
    }
}