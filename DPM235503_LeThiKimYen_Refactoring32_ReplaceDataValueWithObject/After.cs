namespace DPM235503_LeThiKimYen_Refactoring32_ReplaceDataValueWithObject
{
    public class Customer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }
    }

    public class OrderAfter
    {
        // Thay dữ liệu chuỗi bằng một đối tượng Customer chuyên biệt
        public Customer Customer { get; set; }

        public OrderAfter(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}