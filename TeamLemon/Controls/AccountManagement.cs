using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Controls
{
    public class AccountManagement
    {
      
        public static void CreateNewAcc(User currentUser)
        {
            Console.Clear();
            Console.WriteLine("You are creating a new account");
            Console.Write("What would you like to name your account?: ");
            string accName = Console.ReadLine();

            // Generates a new unique ID for the specified account using Guid-struct.
            var id = Guid.NewGuid().ToString();
            var result = id.Substring(0,6);

            Account tempAcc = new Account() {AccountName = accName, Balance = 0 , AccountID = result};

            foreach (var item in Account.AllAccounts)
            {
                if (item.Key == currentUser.ID)
                {
                    item.Value.Add(tempAcc);
                    break;
                }
            }

        }
        public static void MonitorAccounts(User currentUser)
        {
            Account.AllAccounts.TryGetValue(currentUser.ID, out List<Account> currentAccount);
            int i = 1;
            foreach (Account account in currentAccount)
            {
                Console.WriteLine(i + ": " + account.ToString());
                i++;
            }
        }

        public static void InternalTransfer(User currentUser)
        {
            Console.Clear();
            Console.WriteLine("Internal Transfer");
            MonitorAccounts(currentUser);

            int fromAccount = 0;
            int toAccount = 0;
            decimal amountToTransfer = 0;
            bool IsTransfer = true;

            while (IsTransfer) 
            {
                Console.WriteLine("Choose account to transfer from.");
                int.TryParse(Console.ReadLine(),out fromAccount);
                if (ValidateFromAccount(currentUser,fromAccount,toAccount)) 
                {
                    IsTransfer = false;
                }
            }
            fromAccount--;
            while (!IsTransfer)
            {
                Console.WriteLine("Choose account to transfer to.");
                int.TryParse(Console.ReadLine(), out toAccount);
                toAccount--;
                if (ValidateToAccount(currentUser,fromAccount,toAccount))
                {
                    IsTransfer = true;
                }
            }
            while (IsTransfer)
            {
                Console.WriteLine("How much do you want to transfer?");

                decimal.TryParse(Console.ReadLine(), out amountToTransfer);
                if (Account.AllAccounts[currentUser.ID][fromAccount].Balance < amountToTransfer)
                {
                    Console.WriteLine("The amount is to high or to low for what exists on the account");
                }
                else if (amountToTransfer <= -1)
                {
                    Console.WriteLine("Please enter a sum greater than 0");
                }
                else
                {
                    IsTransfer = false;
                }
            }

            Account.AllAccounts[currentUser.ID][fromAccount].Balance -= amountToTransfer;
            Account.AllAccounts[currentUser.ID][toAccount].Balance += amountToTransfer;
        }

        public static void ExternalTransfer(User currentUser)
        {
            int fromAccount = 0;
            int toAccount = 10;
            decimal amountToTransfer = 0;
            var foundAccount = new Account();
            Console.Clear();
            Console.WriteLine("External transfer");

            var isTransfering = true;

            MonitorAccounts(currentUser);
            while (isTransfering)
            {

                Console.WriteLine("From what account do you wish to transfer from?");
                int.TryParse(Console.ReadLine(), out fromAccount);
                fromAccount--;
                if (!ValidateFromAccount(currentUser, fromAccount, toAccount))
                {
                    continue;
                }

                Console.WriteLine("Enter the account number below you wish to transfer the money to");
                var inputAccNumber = Console.ReadLine();
                var ID = ValidateAccountNumber(inputAccNumber);
                Console.WriteLine("Enter the amount to transfer to the account");
                if (decimal.TryParse(Console.ReadLine(), out amountToTransfer) && amountToTransfer >= 0 
                    && amountToTransfer !> Account.AllAccounts[currentUser.ID][fromAccount].Balance)
                {
                    MakeExternalTransfer(currentUser, ID, amountToTransfer, fromAccount, inputAccNumber);

                    isTransfering = false;
                }
                else
                {
                    Console.WriteLine("Invalid amount to transfer");
                }

            }

            MenuClass.ContinueToMenu();
        }


        // Methods for checking if the accounts exists. Will be reused in external transfer.
        private static bool ValidateFromAccount(User currentUser, int fromAccount, int toAcccount)
        {
            if (fromAccount <= Account.AllAccounts[currentUser.ID].Count && fromAccount != toAcccount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong account input, select between the accounts you have");
                return false;
            }
        }
        private static bool ValidateToAccount(User currentUser, int fromAccount, int toAccount)
        {
            if(toAccount <= Account.AllAccounts[currentUser.ID].Count && toAccount != fromAccount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Wrong account input, select between the accounts you have");
                return false;
            }
        }
        private static int ValidateAccountNumber(string inputAccNumber)
        {

            var foundID = 0;
            foreach (var item in Account.AllAccounts)
            {
                foreach (Account account in item.Value.Where(x => x.AccountID == inputAccNumber))
                {
                    foundID = item.Key;
                }
            }
            return foundID;
        }
        private static void MakeExternalTransfer(User currentUser, int toAccountKey, decimal amount
            , int fromAccount, string inputAccNumber)
        {
            Account.AllAccounts[currentUser.ID][fromAccount].Balance -= amount;
            Account.AllAccounts[toAccountKey].Where(x => x.AccountID == inputAccNumber).ToList()
                .ForEach(y => y.Balance += amount);
        }
    }
}
