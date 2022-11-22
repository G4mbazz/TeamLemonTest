using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Models
{
    public class Admin : Person
    {
        public static Dictionary<int, Person> allUsers()
        {
            Person Sebastian = new Person()
            {
                Name = "Sebastian",
                Password = "LandFall",
                IsAdmin = false,
                ID = 1001
            };
            Person Patrik = new Person()
            {
                Name = "Patrik",
                Password = "Horror",
                IsAdmin = false,
                ID = 1002
            };
            Person Leo = new Person()
            {
                Name = "Leo",
                Password = "MTG",
                IsAdmin = false,
                ID = 1003
            };
            Person Theo = new Person()
            {
                Name = "Theo",
                Password = "CarLover",
                IsAdmin = false,
                ID = 1004
            };
            Person Anas = new Person()
            {
                Name = "Anas",
                Password = "coolshirt",
                IsAdmin = true,
                ID = 1005
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
