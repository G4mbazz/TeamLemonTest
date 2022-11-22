using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;
using System.Linq;

namespace TeamLemon.Controls
{
    class LoginClass
    {
        public static void Login(Dictionary<int, Person> allUsers)
        {
            bool ok = false;
            var current = new Person();
            do
            {
                Console.WriteLine("Welcome the bank\n");
                Console.Write("Username:");
                var username = Console.ReadLine();
                Console.Write("\nPassword:");
                var password = Console.ReadLine();
                current = LoginValidation(allUsers, username, password);
                if (current != null && current.LoginAttempts != 0)
                {
                    ok = true;
                }
                else
                {
                    continue;
                }
            } while (ok == false);

            MenuClass.Menu(current);
            }


        /// <summary>
        /// Method to check if the user exists
        /// </summary>
        /// <param name="allUsers"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Returns either the current user if it exists, else returns null</returns>
        private static Person LoginValidation(Dictionary<int,Person> allUsers,string username, string password)
        {
            bool found = false;
            Person current = new Person();
            foreach (var item in allUsers)
            {
                if (item.Value.Name == username && item.Value.Password == password)
                {
                    found = true;
                    current = item.Value;
                    break;
                }
            }
            if(found == true && current.LoginAttempts != 0)
            {
                return current;
            }
            else
            {
                return null;
            }
        }
    }
}

