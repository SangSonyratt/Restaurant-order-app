using RESTAPP.Model;
using RESTAPP.ViewPage.ResponsePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.Mainviews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservation : ContentPage
    {
        public Reservation()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Response_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReservationResponse());
        }
    }
}