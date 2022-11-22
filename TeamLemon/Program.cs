using System;
using TeamLemon.Models;
using TeamLemon.Controls;
namespace TeamLemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = User.AllUsers();

            LoginClass.Login(dict);
        }
    }
}
