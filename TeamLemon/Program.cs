using System;
using TeamLemon.Models;
using TeamLemon.Controls;
namespace TeamLemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDict = User.AllUsers();
            var adminDict = Admin.AllAdmins();

            LoginClass.LoginValidation(userDict,adminDict);

            
        }
    }
}
