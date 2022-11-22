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
            int current;
            Console.WriteLine("Welcome the bank\n");
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("\nPassword:");
            var password = Console.ReadLine();

            foreach (var item in allUsers)
            {
                if(item.Value.Name == username && item.Value.Password == password)
                {
                    found = true;
                    current = item.Key;
                }
                else
                {
                    Console.WriteLine("Wrong username or password");
                }
            }

        }
    }
}
