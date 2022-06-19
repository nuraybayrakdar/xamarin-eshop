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
    class SearchResultViewModel : BaseViewModel
    {
        public SearchResultViewModel()
        {
            Products = DataHolder.FilteredList;
        }
    }
}
