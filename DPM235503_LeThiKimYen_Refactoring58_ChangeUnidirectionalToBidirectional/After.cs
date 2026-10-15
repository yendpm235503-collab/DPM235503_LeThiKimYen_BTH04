using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring58_ChangeUnidirectionalToBidirectional
{
    public class CustomerAfter
    {
        public List<OrderAfter> Orders { get; } = new List<OrderAfter>();
    }

    public class OrderAfter
    {
        private CustomerAfter _customer;

        public CustomerAfter Customer
        {
            get => _customer;
            set
            {
                if (_customer != null) _customer.Orders.Remove(this);
                _customer = value;
                if (_customer != null) _customer.Orders.Add(this);
            }
        }
    }
}