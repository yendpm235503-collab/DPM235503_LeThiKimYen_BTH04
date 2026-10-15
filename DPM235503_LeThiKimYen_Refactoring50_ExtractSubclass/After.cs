namespace DPM235503_LeThiKimYen_Refactoring50_ExtractSubclass
{
    public class JobItemAfter
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public virtual int GetTotalPrice() => UnitPrice * Quantity;
    }

    // Tách Lớp con LaborItem chuyên xử lý các mục công việc nhân công
    public class LaborItem : JobItemAfter
    {
        public string Employee { get; set; }

        public LaborItem(string employee, int unitPrice, int quantity)
        {
            Employee = employee;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}