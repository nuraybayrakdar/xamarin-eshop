using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using eShopOnContainers.Core.Views;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.DataHolder;
using System.Threading;

namespace eShopOnContainers.Core.ViewModels
{
    class SearchPageViewModel : BaseViewModel
    {
        public string Keyword { get; set; }
        public Command SearchCommand { get; }

        public SearchPageViewModel()
        {
            SearchCommand = new Command(SearchByName);
        }

        private async void SearchByName()
        {
            DataHolder.GetProductsByName(Keyword);
            await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}/{nameof(AramaSonucu)}");
        }

    }
}
