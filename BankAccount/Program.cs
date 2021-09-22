using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAccount Account1 = new CheckingAccount();
            Account1.CreateAccount();
            Account1.PrintAccount();

            BaseAccount Account2 = new SavingAccount(0.05);
            Account2.CreateAccount();
            Account2.PrintAccount();
        }
    }
}
