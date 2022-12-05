using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;
using System.Linq;

namespace TeamLemon.Controls
{
    public class LoanMangement
    {
        public static void TakeALoan(User currentUser)
        {
            LoanMangement manager = new LoanMangement();
            var takingLoan = true;
            var amountToLoan = 0.0m;
            while (takingLoan)
            {
                Console.Clear();
                Console.WriteLine("Take a loan");
                if (manager.UserLoanValidation(currentUser))
                {
                    Console.WriteLine("You already have a loan at the bank");
                    takingLoan = false;
                    MenuClass.ContinueToMenu();
                }
                Console.WriteLine("Enter the amount you wish to loan" +
                    $"\nYour current loancelling is at: {manager.CalculateLoanCelling(currentUser)}");
                decimal.TryParse(Console.ReadLine(), out amountToLoan);
                if(!manager.ValidateLoanAmount(currentUser, amountToLoan))
                {
                    continue;
                }
                Console.WriteLine("To what account to do wish the money be transfered to?\n");
                AccountManagement.MonitorAccounts(currentUser);
                int.TryParse(Console.ReadLine(), out int result);
                if (!AccountManagement.ValidateToAccount(currentUser, 10, result))
                {
                    continue;
                }
                manager.MakeLoanTransfer(currentUser,result,amountToLoan);
                Console.Clear();
                Console.WriteLine("The transfer was successful, You new account balance is now:");
                AccountManagement.MonitorAccounts(currentUser);
                MenuClass.ContinueToMenu();
            }
        }
        private bool UserLoanValidation(User currentUser)
        {
            var found = false;
            foreach (var item in Loan.AllLoans)
            {
                found = item.Value.User == currentUser ? true : false;
            }
            return found;
        }
        public decimal CalculateLoanCelling(User currentUser)
        {
            Account.AllAccounts.TryGetValue(currentUser.ID, out List<Account> accounts);
            decimal loanCelling = 0;

            foreach (Account account in accounts)
            {
                loanCelling += account.Balance;
            }
            loanCelling *= 5;
            return loanCelling;
        }
        private bool ValidateLoanAmount(User currentUser, decimal amount)
        {
            if(amount > CalculateLoanCelling(currentUser) && currentUser.AmountLeftToLoan !< amount)
            {
                Console.WriteLine("You can't take a loan over your loan celling" +
                    ", Press enter to try again");
                Console.ReadKey();
                return false;
            }
            return true;
        }
        private void MakeLoanTransfer(User currentUser,int accountIndex ,decimal amountToLoan)
        {
            Account.AllAccounts[currentUser.ID][accountIndex].Balance += amountToLoan;
            Loan.AllLoans.Add(currentUser.ID, new Loan { User = currentUser, Amount = amountToLoan });
            User.AllUsers[User.AllUsers.IndexOf(currentUser)].AmountLeftToLoan += CalculateLoanCelling(
                currentUser) - amountToLoan;
        }
    }
}
