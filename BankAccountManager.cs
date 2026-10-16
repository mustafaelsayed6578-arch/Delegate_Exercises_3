using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exercises_3
{
    public class BankAccountManager
    {
        public event EventHandler<TransactionEventArgs> OnTransactionCompleted;

        private Customer _customer;

        public BankAccountManager(Customer customer)
        {
            _customer = customer;
        }

        private void OnWithdrawCompleted(TransactionEventArgs e)
        {
            OnTransactionCompleted?.Invoke(this, e);
        }

        public void Withdraw(decimal amount)
        {
            if (amount > _customer.Balance)
            {
                Console.WriteLine($"{_customer.AccountName}: Amount is larger than Account Balance!");
                return; 
            }

            decimal remainingBalance = _customer.Balance - amount;

            Console.WriteLine($"{_customer.AccountName} withdrew successfully!");

            OnWithdrawCompleted(new TransactionEventArgs(amount, remainingBalance, "Withdrawal successful."));
        }
    }
}