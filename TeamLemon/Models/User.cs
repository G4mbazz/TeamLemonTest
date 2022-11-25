using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TeamLemon.Models
{
    public class User : Person
    {
        public static List<User> AllUsers { get; set; } = new List<User>();
        public static void initUsers()
        {
            User sebastian = new User()
            {
                Name = "Sebastian",
                Password = "LandFall",
                IsAdmin = false,
                ID = 1001,
                LogInAttempt = 3,
                LockedUser = false,
                Accounts = new List<Account>()
                {
                    new Account{AccountName = "Savings: ", Balance = 1432.34m},
                    new Account{AccountName = "Salery: ", Balance = 10000.00m}
                }
            };
            User patrik = new User()
            {
                Name = "Patrik",
                Password = "Horror",
                IsAdmin = false,
                ID = 1002,
                LogInAttempt = 3,
                LockedUser = false,
                Accounts = new List<Account>()
                {
                    new Account{AccountName = "Savings: ", Balance = 1337.00m},
                    new Account{AccountName = "Salery: ", Balance = 420.00m}
                }
            };
            User leo = new User()
            {
                Name = "Leo",
                Password = "MTG",
                IsAdmin = false,
                ID = 1003,
                LogInAttempt = 3,
                LockedUser = false,
                Accounts = new List<Account>()
                {
                    new Account{AccountName = "Savings: ", Balance = 1664.00m},
                    new Account{AccountName = "Salery: ", Balance = 18887.00m}
                }
            };
            User theo = new User()
            {
                Name = "Theo",
                Password = "CarLover",
                IsAdmin = false,
                ID = 1004,
                LogInAttempt = 3,
                LockedUser = false,
                Accounts = new List<Account>()
                {
                    new Account{AccountName = "Savings: ", Balance = 740.00m},
                    new Account{AccountName = "Salery: ", Balance = 6400.00m}
                }
            };
            AllUsers.Add(sebastian);
            AllUsers.Add(patrik);
            AllUsers.Add(leo);
            AllUsers.Add(theo);
            foreach (User user in AllUsers)
            {
                Account.AllAccounts.Add(user.ID, user.Accounts);
            }
        }

        public static void MonitorAccounts(User currentUser)
        {
            Account.AllAccounts.TryGetValue(currentUser.ID, out List<Account> currentAccount);

            foreach (Account account in currentAccount)
            {
                Console.WriteLine(account.ToString());
            }
        }
    }
}

