using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Models
{
    public class Admin : Person
    {

        public static List<Admin> AllAdmins { get; set; } = new List<Admin>();
        
        public static void initAdmins()
        {
            Admin anas = new Admin()
            {
                Name = "Anas",
                Password = "coolshirt",
                ID = 1005,
                IsAdmin = true,
                LockedUser = false,
                LogInAttempt = 3
            };
            AllAdmins.Add(anas);
        }
        public void CreateNewUser()
        {
            var allUsers = User.AllUsers;
            string _username = null;
            string _password = null;
            int _id;

            // Get unique username
            do
            {
                Console.Write("Username : ");
                string input = Console.ReadLine();
                bool isUnique = true;

                if (input != null)
                {
                    // Loop through all users names to see if this username is unique
                    foreach (var user in allUsers)
                    {
                        if (user.Name.ToLower() == input.ToLower())
                        {
                            // If a matching name is found this username is not unique
                            isUnique = false;
                        }
                    }

                    // If the username is unique then _username = the new username
                    // If it is not unique then ask for another username
                    if (!isUnique)
                    {
                        Console.WriteLine("Your username is not unique.");
                    }
                    else
                    {
                        _username = input;
                    }
                }
            } while (_username == null);

            // Get the password
            do
            {
                Console.Write("Password : ");
                string input = Console.ReadLine();

                if (input != null)
                {
                    _password = input;    
                }

            } while (_password == null);

            // Get id 
            _id = 1001 + User.AllUsers.Count;

            // Create a new user
            User newUser = new User()
            {
                Name = _username,
                Password = _password,
                ID = _id,
                IsAdmin = false,
                LogInAttempt = 3,
                LockedUser = false,
                Accounts = new List<Account>()
                {
                    new Account(){AccountName = "Salary", Balance = 0}
                }
            };


            // Append to AllUsers
            User.AllUsers.Add(newUser);

        }
    }
}
