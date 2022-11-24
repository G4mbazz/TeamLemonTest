using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Models
{
    public class User : Person
    {

        public static List<User> AllUsers()
        {

            User Sebastian = new User()
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
            User Patrik = new User()
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
            User Leo = new User()
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
            User Theo = new User()
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
            var AllPersons = new List<User>();
            AllPersons.Add(Sebastian);
            AllPersons.Add(Patrik);
            AllPersons.Add(Leo);
            AllPersons.Add(Theo);

            return AllPersons;
        }
    }
}

