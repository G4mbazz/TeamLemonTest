using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Controls
{
    public class AccountManagement
    {
      
        public static void CreateNewAcc(User cUser)
        {
            Console.Clear();
            Console.WriteLine("You are creating a new account");
            Console.Write("What would you like to name your account?: ");
            string accName = Console.ReadLine();
            Account tempAcc = new Account() {AccountName = accName, Balance = 0 };

            foreach (var item in Account.AllAccounts)
            {
                if (item.Key == cUser.ID)
                {
                    item.Value.Add(tempAcc);
                    break;
                }
            }

        }

        public static void AccountInfo()
        {

        }
    }
}
