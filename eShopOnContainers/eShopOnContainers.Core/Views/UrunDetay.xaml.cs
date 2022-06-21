using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.Models;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrunDetay : ContentPage
    {
        public UrunDetay(Product selectedProduct)
        {
            InitializeComponent();
            BindingContext = new UrunDetayViewModel(selectedProduct);
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = ((CollectionView)sender).SelectedItem as Product;
            if (selectedProduct == null)
                return;

            await Navigation.PushAsync(new UrunDetay(selectedProduct));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}