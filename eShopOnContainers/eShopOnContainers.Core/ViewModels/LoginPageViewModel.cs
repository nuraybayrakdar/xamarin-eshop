using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using eShopOnContainers.Core.Views;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.FirebaseManager;

namespace eShopOnContainers.Core.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {

        public string Username { get; set; }
        public string RegisterUsername { get; set; }
        public string Password { get; set; }
        public string RegisterPassword { get; set; }

        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(Register);
        }

        public async void Login()
        {
            Account LoginAccount = new Account(Username, Password);
            //var AccountList = await DatabaseManager.GetAccount();
            var AccountList = await FirebaseManager.GetAccount();
            foreach (Account account in AccountList)
            {
                if (account.Username == LoginAccount.Username && account.Password == LoginAccount.Password)
                {
                    SetCurrentAccount(LoginAccount);
                    AppShell denemeShell = new AppShell();
                    denemeShell.Login();
                    App.Current.MainPage = denemeShell;
                    await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}");
                }
            }
        }

        private async void Register()
        {
            Account RegisterAccount = new Account(RegisterUsername, RegisterPassword);
            //await DatabaseManager.AddAccount(RegisterAccount);

            await FirebaseManager.AddAccount(RegisterAccount);
        }


    }
}
