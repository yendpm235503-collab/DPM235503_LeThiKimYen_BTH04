namespace DPM235503_LeThiKimYen_Refactoring32_ReplaceDataValueWithObject
{
    public class OrderBefore
    {
        // Khách hàng chỉ là một chuỗi string đơn giản
        public string Customer { get; set; }

        public OrderBefore(string customer)
        {
            Customer = customer;
        }
    }
}