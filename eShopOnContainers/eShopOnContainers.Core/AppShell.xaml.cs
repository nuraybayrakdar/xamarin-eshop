using Xamarin.Forms;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.Views;
using eShopOnContainers.Core.Services;

namespace eShopOnContainers.Core
{
    public partial class AppShell : Xamarin.Forms.Shell
    {

        public AppShell()
        {
            InitializeComponent();
            AccountPage.IsVisible = false;
          //  Routing.RegisterRoute(nameof(Sepet), typeof(Sepet));
            Routing.RegisterRoute(nameof(AramaSayfasi), typeof(AramaSayfasi));
            Routing.RegisterRoute(nameof(AramaSonucu), typeof(AramaSonucu));
            Routing.RegisterRoute(nameof(SatinAlindi), typeof(SatinAlindi));
        }
        public void Login()
        {
            LoginPage.IsVisible = false;
            AccountPage.IsVisible = true;
        }
    }
}