using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Models
{
    public class Account
    {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public static Dictionary<int, List<Account>> AllAccounts { get; set; } = new Dictionary<int, List<Account>>();

        public override string ToString()
        {
            return AccountName + " " + Balance;
        }

    }
}
