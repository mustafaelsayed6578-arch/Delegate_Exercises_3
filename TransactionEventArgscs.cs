using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exercises_3
{
    public class TransactionEventArgs : EventArgs
    {
        public decimal Amount { get; }
        public decimal RemainingBalance { get; }
        public string Message { get; }

        public TransactionEventArgs(decimal amount, decimal remainingBalance, string message)
        {
            Amount = amount;
            RemainingBalance = remainingBalance;
            Message = message;
        }
    }
}
