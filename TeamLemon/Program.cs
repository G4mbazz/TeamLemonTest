using System;
using TeamLemon.Models;
using TeamLemon.Controls;
namespace TeamLemon
{
    class Program
    {

        static void Main(string[] args)
        {

            ASCIIArt.IntroArt();

            User.initUsers();
            Admin.initAdmins();


            LoginClass.LoginValidation(User.AllUsers,Admin.AllAdmins);

            
        }
    }
}
