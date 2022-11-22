using System;
using TeamLemon.Models;
using TeamLemon.Controls;
namespace TeamLemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = Admin.allUsers();

            LoginClass.Login(dic);
        }
    }
}
