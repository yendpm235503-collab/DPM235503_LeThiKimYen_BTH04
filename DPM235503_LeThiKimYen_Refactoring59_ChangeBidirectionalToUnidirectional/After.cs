namespace DPM235503_LeThiKimYen_Refactoring59_ChangeBidirectionalToUnidirectional
{
    public class CustomerAfter { }

    public class OrderAfter
    {
        // Chỉ giữ lại liên kết 1 chiều từ Order -> Customer
        public CustomerAfter Customer { get; set; }
    }
}