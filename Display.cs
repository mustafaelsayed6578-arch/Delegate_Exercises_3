using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exercises_3
{
    class Display
    {
        public void Subscribe(BankAccountManager bankAccount)
        {
            bankAccount.OnTransactionCompleted += displayInfo;
        }

        public void displayInfo(object sender, TransactionEventArgs transactionEventArgs)
        {
            Console.WriteLine($"Amount: {transactionEventArgs.Amount}");
            Console.WriteLine($"RemainingBalance:  { transactionEventArgs.RemainingBalance}");
            Console.WriteLine($"Messaage: {transactionEventArgs.Message}");
        }
    }
}
