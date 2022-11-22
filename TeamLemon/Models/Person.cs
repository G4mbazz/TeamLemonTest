using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon
{
    public class Person
    {
        private string _name;
        private string _password;
        private bool _admin;
        private int _id;
        private int _logInAttempt;
        public string Name { get => _name; set { _name = value; } }
        public string Password { get => _password; set { _password = value; } }
        public bool IsAdmin { get => _admin; set { _admin = value; } }
        public int ID { get => _id; set { _id = value; } }
        public int LogInAttempt { get => _logInAttempt; set { _logInAttempt = value; } }
    }
}
