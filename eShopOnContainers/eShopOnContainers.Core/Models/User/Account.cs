using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Plugin.CloudFirestore.Attributes;

namespace eShopOnContainers.Core.Models.User
{
    public class Account
    {
        //for firebase asyncTask
        public static string CollectionPath = "accounts";

        [Id]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Account()
        {

        }
    }
}