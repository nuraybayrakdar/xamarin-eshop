
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.User;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.ViewModels
{
    class AccountPageViewModel : BaseViewModel
    {
        public Command LogoutCommand { get; }
        public string Username { get; set; }

        public AccountPageViewModel()
        {
            LogoutCommand = new Command(Logout);
            if (CurrentAccount() != null)
            {
                Username = CurrentAccount().Username;
            }
        }

        private async void Logout()
        {
            App.Current.MainPage = new AppShell();
            await Shell.Current.GoToAsync($"///{nameof(HomepageViewModel)}");
        }
    }
}
