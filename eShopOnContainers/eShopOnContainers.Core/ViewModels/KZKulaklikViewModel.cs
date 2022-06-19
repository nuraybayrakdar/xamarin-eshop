using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using eShopOnContainers.Core.Services.DataHolder;
using eShopOnContainers.Core.Models.Catalog;

namespace eShopOnContainers.Core.ViewModels
{
    class KZKulaklikViewModel : BaseViewModel
    {
        public KZKulaklikViewModel()
        {
            DataHolder.GetProductsByCategory("kulaklýk");
            Products = DataHolder.FilteredList;
        }

    }
}