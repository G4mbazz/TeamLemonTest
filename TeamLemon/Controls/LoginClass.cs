using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;
using System.Linq;

namespace TeamLemon.Controls
{
    class LoginClass
    {
        public void Login(Dictionary<int,Person> allUsers)
        {
            bool found = false;
            Person current;
            Console.WriteLine("Welcome the bank\n");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("\nPassword:");
            var password = Console.ReadLine();

            foreach (var item in allUsers)
            {
                if(item.Value.LoginAttempts != 0)
                {
                    if (item.Value.Name == username && item.Value.Password == password)
                    {
                        found = true;
                        current = item.Value;
                    }
                    else
                    {
                        Console.WriteLine("Wrong username or password");
                        item.Value.LoginAttempts--;
                    }
                }
            }
            
        }
    }
}
