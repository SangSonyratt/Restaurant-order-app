using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTAPP.ViewPage.Payments;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.Mainviews.MenuComponents
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetails : ContentPage
    {
        public MenuDetails(string menuList, string priceList, string Image, string ingredients)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            menuName.Text = menuList;
            ingredient.Text = ingredients;
            price.Text = priceList;
            price.FontSize = 28;
            Myimage.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }

        private async void Payment_button(object sender, EventArgs e)
        {
            //var txt = e.SelectedItem as MenuList;
            //await Navigation.PushAsync(new MenuDetails(txt.menuList, txt.priceList));
            await Navigation.PushAsync(new Payment(menuName, price));
        }

        private async void TapGestureRecognizer_BackToMenuTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private void TapGestureRecognizer_NextTapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_PreviousTapped(object sender, EventArgs e)
        {

        }
    }
}