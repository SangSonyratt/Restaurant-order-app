using RESTAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupPage : ContentPage
	{
		public SignupPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void Signup_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewPage.MainView());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}