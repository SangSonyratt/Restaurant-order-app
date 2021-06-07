using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace test_matserdetailpage.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected INavigation Navigation { get; set; }
        private string _AppName;
        protected string AppName
        {
            get
            {
                return _AppName;
            }
            set
            {
                _AppName = value;
                NotifyPropertyChanged("AppName");
            }
        }

        public void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
