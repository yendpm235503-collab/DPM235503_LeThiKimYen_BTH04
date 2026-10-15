namespace DPM235503_LeThiKimYen_Refactoring46_ReplaceErrorCodeWithException
{
    public class AccountBefore
    {
        private double _balance = 500;

        // Trả về mã lỗi -1 nếu không đủ tiền (dễ gây mơ hồ)
        public int Withdraw(double amount)
        {
            if (amount > _balance) return -1;
            _balance -= amount;
            return 0;
        }

        public double GetBalance() => _balance;
    }
}