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
            Account tempAcc = new Account() {AccountName = accName, Balance = 0 };

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

            int fromAccount;
            int toAccount;
            decimal amountToTransfer;

            while (true) { 
                Console.WriteLine("Choose account to transfer from.");

                if (int.TryParse(Console.ReadLine(), out fromAccount) && fromAccount <= Account.AllAccounts[currentUser.ID].Count) { break; }
            }

            while (true)
            {
                Console.WriteLine("Choose account to transfer to.");

                if (int.TryParse(Console.ReadLine(), out toAccount) && toAccount <= Account.AllAccounts[currentUser.ID].Count && fromAccount != toAccount) { break; }
            }

            while (true)
            {
                Console.WriteLine("How much do you want to transfer?");

                decimal.TryParse(Console.ReadLine(), out amountToTransfer);
                if (amountToTransfer < 4) { break; }

            }
        }
    }
}
