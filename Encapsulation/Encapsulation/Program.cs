// bundling data (fields) and the methods that operate on that data into a single unit, known as a class.
// Protecting data using private fields and public methods/properties.

using System;

class BankAccount
{
    private double balance; 

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        Console.WriteLine("Current Balance: " + acc.GetBalance());
    }
}
