using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Controls
{
    class MenuClass
    {
        public void AdminMenu(Person admin)
        {
            // Add Admin methods to create users.
        }
        public void UserMenu(Person currentUser)
        {
            Console.WriteLine($"Welcome {currentUser.Name}");
        }
    }
}
