using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Controls
{
    class MenuClass
    {
        public void AdminMenu(Person admin)
        {
            // Add Admin methods to create users.
            Console.WriteLine("I AM ADMIN");
        }
        public void UserMenu(Person currentUser)
        {
            Console.WriteLine($"Welcome {currentUser.Name}");
        }
    }
}
