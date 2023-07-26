using System;

namespace Assignment16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            BankAccount account = new BankAccount(accountHolderName);

            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            try
            {
                account.Deposit(depositAmount);
                Console.WriteLine("Account Holder: " + account.AccountHolderName);
                Console.WriteLine("Account Number: " + account.AccountNumber);
                Console.WriteLine("Balance after deposit: $" + account.GetBalance());

                Console.Write("Enter amount to withdraw: ");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());


                try
                {
                    account.Withdraw(withdrawalAmount);
                    Console.WriteLine("Balance after withdrawal: $" + account.GetBalance());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();

        }
    }
}