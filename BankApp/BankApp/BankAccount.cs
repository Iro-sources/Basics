using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    //Properties
    public class BankAccount
    {

        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string owner)
        {
            //Assigning the parameter 'owner' to the property 'Owner'
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }


    }


    
}