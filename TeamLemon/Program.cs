using System;
using TeamLemon.Models;
using TeamLemon.Controls;
namespace TeamLemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = User.AllUsers();
            var adminList = Admin.AllAdmins();

            LoginClass.LoginValidation(userList,adminList);

            
        }
    }
}
