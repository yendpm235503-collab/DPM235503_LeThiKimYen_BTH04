using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring57_ChangeValueToReference
{
    public class CustomerAfter
    {
        public string Name { get; private set; }
        public CustomerAfter(string name) { Name = name; }
    }

    public class CustomerRepository
    {
        private static Dictionary<string, CustomerAfter> _instances = new Dictionary<string, CustomerAfter>();

        public static CustomerAfter GetCustomer(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new CustomerAfter(name);
            }
            return _instances[name];
        }
    }

    public class OrderAfter
    {
        public CustomerAfter Customer { get; set; }
        public OrderAfter(string customerName)
        {
            // Lấy tham chiếu duy nhất từ Repository
            Customer = CustomerRepository.GetCustomer(customerName);
        }
    }
}