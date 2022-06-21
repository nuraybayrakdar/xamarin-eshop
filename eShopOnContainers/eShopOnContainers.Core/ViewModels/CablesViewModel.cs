using eShopOnContainers.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using eShopOnContainers.Core.Services.DataHolder;

namespace eShopOnContainers.Core.ViewModels
{
    class CablesViewModel : BaseViewModel
    {
        public CablesViewModel()
        {
            DataHolder.GetProductsByCategory("kablo");
            Products = DataHolder.FilteredList;
        }
    }
}
