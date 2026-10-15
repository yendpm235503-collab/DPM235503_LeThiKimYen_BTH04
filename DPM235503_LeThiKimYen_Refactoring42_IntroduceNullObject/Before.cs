namespace DPM235503_LeThiKimYen_Refactoring42_IntroduceNullObject
{
    public class CustomerBefore
    {
        public string Name { get; set; } = "Khách Hàng X";
    }

    public class BeforeExample
    {
        public string GetCustomerName(CustomerBefore customer)
        {
            if (customer == null)
            {
                return "Khách Lẻ (Chưa Đăng Ký)";
            }
            return customer.Name;
        }
    }
}