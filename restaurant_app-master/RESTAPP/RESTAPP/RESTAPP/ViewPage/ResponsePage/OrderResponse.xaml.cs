using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.ResponsePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderResponse : ContentPage
    {
        public OrderResponse()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}