using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Models
{
    public class User : Person
    {

        public static Dictionary<int, Person> AllUsers()
        {

            User Sebastian = new User()
            {
                Name = "Sebastian",
                Password = "LandFall",
                IsAdmin = false,
                ID = 1001,
                LogInAttempt = 3
            };
            User Patrik = new User()
            {
                Name = "Patrik",
                Password = "Horror",
                IsAdmin = false,
                ID = 1002,
                LogInAttempt = 3
            };
            User Leo = new User()
            {
                Name = "Leo",
                Password = "MTG",
                IsAdmin = false,
                ID = 1003,
                LogInAttempt = 3
            };
            User Theo = new User()
            {
                Name = "Theo",
                Password = "CarLover",
                IsAdmin = false,
                ID = 1004,
                LogInAttempt = 3
            };
            Admin Anas = new Admin()
            {
                Name = "Anas",
                Password = "coolshirt",
                IsAdmin = true,
                ID = 1005,
            };
            Dictionary<int, Person> AllPersons = new Dictionary<int, Person>();
            AllPersons.Add(Sebastian.ID, Sebastian);
            AllPersons.Add(Patrik.ID, Patrik);
            AllPersons.Add(Leo.ID, Leo);
            AllPersons.Add(Theo.ID, Theo);
            AllPersons.Add(Anas.ID, Anas);


            return AllPersons;
        }
    }
}

