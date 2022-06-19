using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Services.DataHolder;
using System.Threading;

namespace eShopOnContainers.Core.ViewModels
{
    public class HomepageViewModel : BaseViewModel
    {
        public HomepageViewModel()
        {
            Products = DataHolder.Products;
        }

    }


}