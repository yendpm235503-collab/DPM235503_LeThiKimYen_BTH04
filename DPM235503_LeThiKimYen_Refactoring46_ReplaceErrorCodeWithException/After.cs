using System;

namespace DPM235503_LeThiKimYen_Refactoring46_ReplaceErrorCodeWithException
{
    public class AccountAfter
    {
        private double _balance = 500;

        // Ném ngoại lệ khi vi phạm nghiệp vụ
        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                throw new InvalidOperationException("Số dư tài khoản không đủ để thực hiện giao dịch.");
            }
            _balance -= amount;
        }

        public double GetBalance() => _balance;
    }
}