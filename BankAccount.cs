using System;

namespace Assignment16
{
    public class BankAccount
    {
        private static int accountnumber = 777;
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        private double Balance { get; set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        private static int GenerateAccountNumber()
        {
            return accountnumber;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }

            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }
        public double GetBalance()
        {
            return Balance;
        }

    }
}