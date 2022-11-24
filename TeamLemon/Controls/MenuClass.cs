using System;
using System.Collections.Generic;
using System.Text;
using TeamLemon.Models;

namespace TeamLemon.Controls
{
    class MenuClass
    {
        public void AdminMenu(Admin admin)
        {
            // Add Admin methods to create users.
            Console.WriteLine("I AM ADMIN");
            admin.CreateNewUser();
        }
        public void UserMenu(User currentUser)
        {
            Console.WriteLine($"Welcome {currentUser.Name}");
        }
    }
}
