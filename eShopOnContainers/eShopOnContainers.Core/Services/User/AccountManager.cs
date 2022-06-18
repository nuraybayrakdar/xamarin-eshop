using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using eShopOnContainers.Core.Models.User;

namespace eShopOnContainers.Core.Services.User
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