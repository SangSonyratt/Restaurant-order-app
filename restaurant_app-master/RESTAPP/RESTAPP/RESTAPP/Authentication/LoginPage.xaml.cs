using RESTAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.Authentication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();
        }

        public ICommand SwitchButton { get; private set; }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }
    }
}