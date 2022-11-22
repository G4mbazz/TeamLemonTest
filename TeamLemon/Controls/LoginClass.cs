using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;
using System.Linq;

namespace TeamLemon.Controls
{
    class LoginClass
    {
        public void Login(Dictionary<int, Person> allUsers)
        {
            bool ok = false;

            do
            {
                Console.WriteLine("Welcome the bank\n");
                Console.Write("Username:");
                var username = Console.ReadLine();
                Console.Write("\nPassword:");
                var password = Console.ReadLine();

                if (LoginValidation(allUsers, username, password) != null)
                {
                    ok = true;
                }
                else
                {
                    continue;
                }
            } while (ok == false);
            }
        private Person LoginValidation(Dictionary<int,Person> allUsers,string username, string password)
        {
            bool found = false;
            Person current = new Person();
            foreach (var item in allUsers)
            {
                if (item.Value.Name == username && item.Value.Password == password && item.Value.LoginAttempts != 0)
                {
                    found = true;
                    current = item.Value;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong username or password");
                    item.Value.LoginAttempts--;
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

