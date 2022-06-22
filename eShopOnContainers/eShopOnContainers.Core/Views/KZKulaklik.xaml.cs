
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KZKulaklik : ContentPage
    {
        public KZKulaklik()
        {
            InitializeComponent();
            BindingContext = new KZKulaklikViewModel();
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