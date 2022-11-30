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
        public static void ContinueToMenu()
        {
            Console.Write("\nPress enter to return to menu: ");
            Console.ReadKey();
        }
        public void UserMenu(User currentUser)
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();

                Console.WriteLine($"Welcome {currentUser.Name}");

                Console.WriteLine("1: Check accounts\n2: Internal transaction\n3: External Transaction\n4: Loan service\n5: Open new account\n6: Changelog\n7: Logout");
                Console.Write("Select: ");
                int.TryParse(Console.ReadLine(), out int result);
                switch (result)
                {
                    case 1:
                        AccountManagement.MonitorAccounts(currentUser);
                        ContinueToMenu();
                        break;
                    case 2:
                        AccountManagement.InternalTransfer(currentUser);
                        ContinueToMenu();
                        break;
                    case 3:
                        //External transfer
                        ContinueToMenu();
                        break;
                    case 4:
                        //Take a Loan
                        ContinueToMenu();
                        break;
                    case 5:
                        AccountManagement.CreateNewAcc(currentUser);
                        ContinueToMenu();
                        break;
                    case 6:
                        //Changelog
                        ContinueToMenu();
                        break;
                    case 7:
                        LoginClass.LoginValidation(User.AllUsers, Admin.AllAdmins);
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choise!");
                        ContinueToMenu();
                        break;
                }

            }
        }
    }
}
