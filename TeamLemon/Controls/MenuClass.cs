using System;
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
            bool loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine($"Welcome {currentUser.Name}");

                Console.WriteLine("1. Check accounts");
                int.TryParse(Console.ReadLine(), out int result);
                switch (result)
                {
                    case 1:
                        AccountManagement.MonitorAccounts(currentUser);
                        Console.ReadKey();
                        break;
                    case 2:
                        AccountManagement.CreateNewAcc(currentUser);
                        Console.ReadKey();
                        break;
                    case 3:
                        LoginClass.LoginValidation(User.AllUsers, Admin.AllAdmins);
                        Console.ReadKey();
                        break;
                    case 4:
                        AccountManagement.InternalTransfer(currentUser);
                        break;





                    default:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
