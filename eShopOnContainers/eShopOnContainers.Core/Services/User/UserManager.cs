using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Navigation2.Services
{
    public static class AccountManager
    {
        public static ObservableCollection<Account> Accounts { get; set; }
        public static Account CurrentAccount { get; set; }

        public static Account GetCurrentAccount()
        {
            return CurrentAccount;
        }

        static AccountManager()
        {
            Accounts = new ObservableCollection<Account>();
            Accounts.Add(new Account
            {
                Username = "Admin",
                Password = "Password"
            });
        }
    }
}
