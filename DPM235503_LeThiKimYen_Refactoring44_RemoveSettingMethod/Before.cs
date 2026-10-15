namespace DPM235503_LeThiKimYen_Refactoring44_RemoveSettingMethod
{
    public class AccountBefore
    {
        public string Id { get; set; } // Dễ bị thay đổi ngẫu nhiên từ bên ngoài

        public AccountBefore(string id)
        {
            Id = id;
        }
    }
}