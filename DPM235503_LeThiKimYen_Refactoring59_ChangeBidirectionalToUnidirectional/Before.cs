using System.Collections.Generic;

namespace DPM235503_LeThiKimYen_Refactoring59_ChangeBidirectionalToUnidirectional
{
    public class CustomerBefore
    {
        // Liên kết 2 chiều không dùng tới gây phức tạp mã nguồn
        public List<OrderBefore> Orders { get; } = new List<OrderBefore>();
    }

    public class OrderBefore
    {
        public CustomerBefore Customer { get; set; }
    }
}