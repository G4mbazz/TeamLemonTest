using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Controls
{
    class MenuClass
    {
        public static void Menu(Person currentUser)
        {
            Console.WriteLine($"Welcome {currentUser.Name}");
        }
    }
}
