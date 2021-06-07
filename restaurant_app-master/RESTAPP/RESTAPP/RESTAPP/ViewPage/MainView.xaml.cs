using RESTAPP.ViewPage.Master_view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_matserdetailpage.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : MasterDetailPage
    {
        public MainView()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
            var menuList = new List<MasterPageItem>();

            var home = new MasterPageItem() { Title = "Home", Icon = "\uf015", TargetType = typeof(Home) };
            var card = new MasterPageItem() { Title = "Card", Icon = "\uf2bb", TargetType = typeof(Card) };
            var map = new MasterPageItem() { Title = "Show on the map", Icon = "\uf5a0", TargetType = typeof(Map) };
            var call = new MasterPageItem() { Title = "Call us", Icon = "\uf879", TargetType = typeof(Call) };
            var notification = new MasterPageItem() { Title = "Notification", Icon = "\uf075", TargetType = typeof(Notification) };
            var taxi = new MasterPageItem() { Title = "Call a taxi", Icon = "\uf1b9", TargetType = typeof(Taxi) };
            var setting = new MasterPageItem() { Title = "Setting", Icon = "\uf013", TargetType = typeof(Settings) };
            menuList.Add(home);
            menuList.Add(notification);
            menuList.Add(card);
            menuList.Add(taxi);
            menuList.Add(call);
            menuList.Add(map);
            menuList.Add(setting);

            NavigationList.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)))
            {
                BarBackgroundColor = Color.Black
            };
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page))
            {
                BarBackgroundColor = Color.Black
            };
            IsPresented = false;
        }

    }
}