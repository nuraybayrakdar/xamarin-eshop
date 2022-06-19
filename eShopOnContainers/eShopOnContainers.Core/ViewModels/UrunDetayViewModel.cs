using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using eShopOnContainers.Core.Models.Product;

namespace eShopOnContainers.Core.ViewModels
{
    public class UrunDetayViewModel : BaseViewModel
    {

        public UrunDetayViewModel(Product selectedProduct)
        {
            SelectedProduct = selectedProduct;

        }


    }
}