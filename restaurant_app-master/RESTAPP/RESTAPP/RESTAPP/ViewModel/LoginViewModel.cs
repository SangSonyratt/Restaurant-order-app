using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RESTAPP.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged;
        private string Phone_number;
        public string PhoneNumber
        {
            get { return Phone_number; }
            set
            {
                Phone_number = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Phone Number"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public object SwitchButton { get; internal set; }

        public void OnSubmit()
        {
            if (Phone_number != "098389908" || password != "nyratt123")
            {
                DisplayInvalidLoginPrompt();
            }
        }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
    }
}