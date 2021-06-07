using RESTAPP.ViewPage.Mainviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.Master_view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Reservation_button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reservation());
        }

        private async void Menu_button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
