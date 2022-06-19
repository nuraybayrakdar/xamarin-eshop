using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Models.Basket;
using eShopOnContainers.Core.Services.User;
using eShopOnContainers.Core.Services.DataHolder;
using eShopOnContainers.Core.Services.Basket;
using Xamarin.Essentials;

namespace eShopOnContainers.Core.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        public Command KZButtonCommand { get; }
        public Command CartButtonCommand { get; }
        public Command SearchButtonCommand { get; }
        public Command SepeteEkleCommand { get; }
        public Command FacebookCommand { get; }
        public Command InstagramCommand { get; }
        public Command TwitterCommand { get; }



        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }


        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public BaseViewModel()
        {
            KZButtonCommand = new Command(GoToMain);
            CartButtonCommand = new Command(GoToCart);
            SepeteEkleCommand = new Command(AddToCart);
            FacebookCommand = new Command(FacebookLink);
            InstagramCommand = new Command(InstagramLink);
            TwitterCommand = new Command(TwitterLink);
            SearchButtonCommand = new Command(GoToSearch);
        }



        public ObservableCollection<CartItem> GetCart()
        {
            return CartManager.Cart;
        }

        //Login iþlemleri
        public Account CurrentAccount()
        {
            return AccountManager.CurrentAccount;
        }
        public void SetCurrentAccount(Account account)
        {
            AccountManager.CurrentAccount = account;
        }

        //
        public void CartWipe()
        {
            CartManager.CleanCart();
        }


        //
        private async void GoToMain(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(Anasayfa)}");
        }
        private async void GoToCart(object obj)
        {
            await Shell.Current.GoToAsync(nameof(Sepet));
        }
        private async void GoToSearch(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AramaSayfasi));
        }

        public void AddToCart()
        {
            CartManager.AddToCart(selectedProduct);
        }

        public void FacebookLink()
        {
            Launcher.OpenAsync(new Uri("https://www.facebook.com/kzkulaklikcom/"));
        }
        public void InstagramLink()
        {
            Launcher.OpenAsync(new Uri("https://www.instagram.com/kzkulaklik/"));
        }
        public void TwitterLink()
        {
            Launcher.OpenAsync(new Uri("https://twitter.com/kzkulaklik"));
        }


    }
}