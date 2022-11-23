using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Models
{
    public class Admin : Person
    {
        
        public static Dictionary<int, Admin> AllAdmins()
        {
            Admin anas = new Admin()
            {
                Name = "Anas",
                Password = "coolshirt",
                ID = 1005,
                IsAdmin = true,
                LockedUser = false
            };

            Dictionary<int, Admin> allAdmins = new Dictionary<int, Admin>();
            allAdmins.Add(anas.ID,anas);
            return allAdmins;
        }

        public void CreateNewUser()
        {
            var allUsers = User.AllUsers();
            string _username = null;

            do
            {
                Console.WriteLine("Username : ");
                string input = Console.ReadLine().ToLower();
                if (input != null)
                {
                    foreach (var user in allUsers)
                    {
                        if (user.Value.Name.ToLower() != input)
                        {
                            _username = input;
                        } else
                        {
                            Console.WriteLine("That username already exists, please enter a new username.");
                            break;
                        }
                    }
                }
            }
            while (_username != null);
        }
    }
}
