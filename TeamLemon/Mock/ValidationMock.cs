using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Mock
{
    public class ValidationMock
    {
        public ValidationMock()
        {
            if (User.AllUsers.Count == 0)
            {
                User.initUsers();
            }
        }
        public static bool ValidateFromAccount(User currentUser, int fromAccount, int toAcccount)
        {
            if (fromAccount <= Account.AllAccounts[currentUser.ID].Count && fromAccount != toAcccount &&
                fromAccount >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateAmount(User currentUser, decimal amountToTransfer, int fromAccount)
        {
            if (amountToTransfer > Account.AllAccounts[currentUser.ID][fromAccount].Balance)
            {
                return false;
            }
            return true;
        }
        public static int ValidateAccountNumber(string inputAccNumber)
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
    }
}
