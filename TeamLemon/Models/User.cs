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
                LockedUser = false
                
            };
            User Patrik = new User()
            {
                Name = "Patrik",
                Password = "Horror",
                IsAdmin = false,
                ID = 1002,
                LogInAttempt = 3,
                LockedUser = false
            };
            User Leo = new User()
            {
                Name = "Leo",
                Password = "MTG",
                IsAdmin = false,
                ID = 1003,
                LogInAttempt = 3,
                LockedUser = false
            };
            User Theo = new User()
            {
                Name = "Theo",
                Password = "CarLover",
                IsAdmin = false,
                ID = 1004,
                LogInAttempt = 3,
                LockedUser = false
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

