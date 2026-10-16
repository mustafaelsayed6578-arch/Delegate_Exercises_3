using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Exercises_3
{
    public class Customer
    {
        public string AccountName { get; }
        public decimal Balance { get; }

        public Customer(string accountName, decimal balance)
        {
            AccountName = accountName;
            Balance = balance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountManager bankAccountManager = new BankAccountManager(new Customer("Mustafa Elsayed", 5000m));
            Display display = new Display();
            display.Subscribe(bankAccountManager);

            Console.WriteLine($"First Operation");
            //warning 
            bankAccountManager.Withdraw(6000);
            Console.WriteLine($"\n\nSecond Operation");
            // safe withdraw
            bankAccountManager.Withdraw(2000);

        }
    }
}
