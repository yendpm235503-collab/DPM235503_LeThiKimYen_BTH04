namespace DPM235503_LeThiKimYen_Refactoring58_ChangeUnidirectionalToBidirectional
{
    public class CustomerBefore { }

    public class OrderBefore
    {
        // Chỉ Order biết Customer, Customer không biết Order của mình
        public CustomerBefore Customer { get; set; }
    }
}