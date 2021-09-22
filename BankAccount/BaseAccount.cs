using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    abstract class BaseAccount
    {
        public int AccountNum { get; set; }
        public string UserName { get; set; }
        

        public abstract void CreateAccount();
        public virtual void PrintAccount()
        {
            Console.WriteLine("Welcome to the account homepage!");
        }
    }


    class CheckingAccount : BaseAccount
    {
        public decimal Balance { get; set; }

        public override void CreateAccount()
        {
            Console.WriteLine("Thanks for creating a checking account.");
            Console.Write("Enter the amount of your first deposit: ");
            Balance = Convert.ToInt32(Console.ReadLine()) ;
        }
        
        public override void PrintAccount()
        {
            base.PrintAccount();
            Console.WriteLine("Checking account Balance: " + Balance);
        }
    }

    class SavingAccount : BaseAccount
    {
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }
        
        public override void CreateAccount()
        {
            Console.WriteLine("Thanks for creating a saving account.");
            Console.Write("Enter the amount of your first deposit: ");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
        

        public override void PrintAccount()
        {
            Console.WriteLine("Saving account Balance: " + Balance);
            Console.WriteLine("The interest rate now is " + InterestRate);
        }

        public SavingAccount(double i)
        {
            InterestRate = i;
        }
    }

}