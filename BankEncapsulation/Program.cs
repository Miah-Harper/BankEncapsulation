using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();

            bankAccount.Deposit(20.29);
            bankAccount.Withdraw(10.11);
            var amount = bankAccount.GetBalance();

            Console.WriteLine($"Your balance is {amount}");
        }
    }
}

