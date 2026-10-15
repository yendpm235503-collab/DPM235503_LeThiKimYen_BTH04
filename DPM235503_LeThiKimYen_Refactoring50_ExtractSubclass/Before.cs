namespace DPM235503_LeThiKimYen_Refactoring50_ExtractSubclass
{
    public class JobItemBefore
    {
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool IsLabor { get; set; } // Cờ xác định xem có phải nhân công không
        public string Employee { get; set; }

        public int GetTotalPrice()
        {
            return UnitPrice * Quantity;
        }
    }
}