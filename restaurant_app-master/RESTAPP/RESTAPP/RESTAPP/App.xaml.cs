using System;
using RESTAPP.Authentication;
using RESTAPP.ViewPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RESTAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage((Page)Activator.CreateInstance(typeof(LoginPage)))
            {
                BarBackgroundColor = Color.Black
            };
        }
        private Page NavigationPage(LoginPage loginPage)
        {
            throw new NotImplementedException();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
