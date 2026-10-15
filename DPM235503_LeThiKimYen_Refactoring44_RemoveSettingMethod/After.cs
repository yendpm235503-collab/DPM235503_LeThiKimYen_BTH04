namespace DPM235503_LeThiKimYen_Refactoring44_RemoveSettingMethod
{
    public class AccountAfter
    {
        // Loại bỏ Setter công khai, chỉ cho phép gán qua Constructor
        public string Id { get; }

        public AccountAfter(string id)
        {
            Id = id;
        }
    }
}