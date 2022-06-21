using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.Services;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisView : ContentPage
    {
        public GirisView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
        public void Login()
        {
            buton.IsVisible = false;
        }

        private void buton_Clicked(object sender, EventArgs e)
        {

        }
    }
}