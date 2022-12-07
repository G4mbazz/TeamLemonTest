using System;
using TeamLemon.Models;

namespace TeamLemon.Controls
{
    class MenuClass
    {
        public void AdminMenu(Admin admin)
        {
            // Add Admin methods to create users.
            bool IsAdminMenu = true;
            while (IsAdminMenu)
            {
                Console.WriteLine($"Welcome admin {admin.Name}");
                Console.WriteLine("1: Create new user\n2: Change exchange rate\n3: Logout");
                if(int.TryParse(Console.ReadLine(), out int MenuChoice))
                {
                    switch (MenuChoice)
                    {
                        case 1:
                            admin.CreateNewUser();
                            ContinueToMenu();
                            break;
                        case 2:
                            Admin.ExchangeRate();
                            break;
                        case 3:
                            LoginClass.LoginValidation(User.AllUsers, Admin.AllAdmins);
                            IsAdminMenu = false;
                            break;
                    }
                }

            }
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
                        AccountManagement.ExternalTransfer(currentUser);
                        break;
                    case 4:
                        //Take a Loan
                        LoanMangement.TakeALoan(currentUser);
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
