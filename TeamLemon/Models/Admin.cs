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
            string _password = null;

            int _id;

            // Get unique username
            do
            {
                Console.WriteLine("Username : ");
                string input = Console.ReadLine().ToLower();
                bool isUnique = true;

                if (input != null)
                {
                    // Loop through all users names to see if this username is unique
                    foreach (var user in allUsers)
                    {
                        if (user.Value.Name == input)
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
                Console.WriteLine("Password : ");
                string input = Console.ReadLine();

                if (input != null)
                {
                    _password = input;    
                }

            } while (_password == null);

            // Get id 
            _id = 1001 + User.AllUsers().Count;

            // Create a person of user
            User newUser = new User()
            {
                Name = _username,
                Password = _password,
                ID = _id,
                IsAdmin = false,
                LogInAttempt = 3,
                LockedUser = false
            };

            // Append to AllUsers
            User.AllUsers().Add(_id, newUser);

        }
    }
}
