using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;
using System.Linq;

namespace TeamLemon.Controls
{
    /// <summary>
    /// Class to handle login control and logic.
    /// </summary>
    class LoginClass
    {

        /// <summary>
        /// Method to check if the user exists
        /// </summary>
        /// <param name="allUsers"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Returns either the current user if it exists, else returns null</returns>
        public static void LoginValidation(Dictionary<int, User> allUsers,Dictionary<int,Admin> allAdmins)
        {
            var menus = new MenuClass();
            bool LogIn = false;
            bool UserFound = false;
            var currentUser = new User();
            var currentAdmin = new Admin();
            do
            {
                Console.WriteLine("Welcome the bank\n");
                Console.Write("Username: ");
                var username = Console.ReadLine();
                Console.Write("\nPassword: ");
                var password = Console.ReadLine();

                foreach (var user in allUsers)
                {
                    if (user.Value.Name == username && user.Value.Password == password && user.Value.LockedUser == false)
                    {
                        UserFound = true;
                        currentUser = user.Value;
                        LogIn = true;
                        user.Value.LogInAttempt = 3;
                        user.Value.LockedUser = false;
                        break;
                    }
                    else if (user.Value.Name != username ^ user.Value.Password != password)
                    {
                        currentUser = user.Value;
                        user.Value.LogInAttempt--;
                        Console.WriteLine("Wrong username or password");
                    }
                }
                foreach (var admin in allAdmins)
                {
                    if (admin.Value.Name == username && admin.Value.Password == password)
                    {
                        UserFound = true;
                        currentAdmin = admin.Value;
                        LogIn = true;
                        break;
                    }
                }
                if (currentUser.LogInAttempt <= 0 && currentAdmin.IsAdmin != true)
                {
                    Console.WriteLine("The user is locked");
                    currentUser.LockedUser = true;
                    LogIn = false;
                    continue;
                }
            } while (LogIn == false);
            if (currentAdmin.IsAdmin == true)
            {
                menus.AdminMenu(currentAdmin);
            }
            else
            {
                menus.UserMenu(currentUser);
            }           
        }
    }
}

