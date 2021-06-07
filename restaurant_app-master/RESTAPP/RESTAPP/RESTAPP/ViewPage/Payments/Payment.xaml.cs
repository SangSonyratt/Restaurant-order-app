using RESTAPP.Model;
using RESTAPP.ViewPage.ResponsePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.Payments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Payment : INotifyPropertyChanged
    {
        public Payment(Label menuName, Label price)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            list.ItemsSource = new List<PaymentList>() {
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                },
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                },
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                },
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                },
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                },
                new PaymentList()
                {
                    Name = menuName.Text,
                    Price = price.Text
                }
            };

            MinusBtn = new Command(() => Number--);
            PlusBtn = new Command(() => Number++);

        }

        private int number = 0;
        public int Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

        public Command MinusBtn { get; set; }
        public Command PlusBtn { get; set; }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderResponse());
        }

        private async void TapGestureRecognizer_PayCashTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderResponse());
        }

    }
}