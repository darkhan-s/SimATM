using System;

namespace SimATM
{
    class Account
    {
        // Declares account variables
        private int accountNum;
        private int pin;
        public int balance;

        //the account's data is loaded
        public Account(int b, int p, int numA)
        {
            this.accountNum = numA;
            this.balance = b;
            this.pin = p;
        }

        // checks if the pin is correct, compares with the data given
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true; // True if Pin numbers are correct
            }
            else
            {
                return false; // False if Pin numbers are incorrect
            }
        }

        // Gets operation for account number

        public int getAccountNum()
        {
            return accountNum;
        }

        // Gets operation for accounts balance

        public int getBalance()
        {
            return balance;
        }

        // Deducts total money from account if the amount is smaller than or equal to the balance

        public Boolean decrementBalance(int amount)
        {
            int b = balance;
            
            if (Details.recStatusDR() == true)
            {
                //gives an artificial delay to see the data race
                System.Threading.Thread.Sleep(5000);

            }

            if (balance >= amount)
            {
                balance = b - amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Sets operation for accounts balance

        public void setBalance(int newBalance)
        {
            balance = newBalance;
        }

    }
}
