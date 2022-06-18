using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Plugin.CloudFirestore.Attributes;

namespace Navigation2.Models
{
    public class Account
    {
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