using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.Service.Catalog;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AramaSayfasi : ContentPage
    {
        public AramaSayfasi()
        {
            InitializeComponent();
            BindingContext = new AramaSayfasiPageViewModel();
        }
    }
}