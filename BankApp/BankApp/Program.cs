using BankApp;
using System;

public class Program {  
public static void Main(string[] args)
{
    List<BankAccount> BankAccounts = new List<BankAccount>();
    
    Console.Write("Enter your name");
    String owner = Console.ReadLine();
    BankAccount bankAccount = new BankAccount(owner);

    Console.Write("Enter initial deposit");
    decimal depositAmount;
    decimal.TryParse(Console.ReadLine(), out depositAmount);
    bankAccount.Deposit(depositAmount);
        //bankAccount.Balance = 0;
        // bankAccount.AccountNumber = Guid.NewGuid();

    BankAccounts.Add(bankAccount);
    foreach (var account in BankAccounts)
        {
            Console.WriteLine($"Owner: {account.Owner}, Account Number: {account.AccountNumber}, Balance: {account.Balance} Kr");
        }
        //BankAccount bankAccount1 = new BankAccount("Ali");
        //bankAccount.Balance = 0;
        // bankAccount.AccountNumber = Guid.NewGuid();
        /*bankAccount1.Deposit(500);
        bankAccount1.Withdraw(100);

        BankAccounts.Add(bankAccount);
        BankAccounts.Add(bankAccount1);*/

        //Printing out
        /*Console.WriteLine($"Owner: {bankAccount.Owner}");
        Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
        Console.WriteLine($"Balance: {bankAccount.Balance} Kr");*/
}
}