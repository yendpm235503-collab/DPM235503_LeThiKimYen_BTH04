namespace DPM235503_LeThiKimYen_Refactoring57_ChangeValueToReference
{
    public class CustomerBefore
    {
        public string Name { get; set; }
        public CustomerBefore(string name) { Name = name; }
    }

    public class OrderBefore
    {
        public CustomerBefore Customer { get; set; }
        public OrderBefore(string customerName)
        {
            // Mỗi đơn hàng tự tạo ra một thể hiện Customer mới trùng lặp
            Customer = new CustomerBefore(customerName);
        }
    }
}