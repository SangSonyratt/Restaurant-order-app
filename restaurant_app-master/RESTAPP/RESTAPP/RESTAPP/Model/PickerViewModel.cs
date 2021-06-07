using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RESTAPP.Model
{
    public class PickerViewModel: INotifyPropertyChanged
    {
        string _selectedItem;
        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                NotifyPropertyChanged("SelectedItemsValue");
            }
        }
        public string SelectedItemsValue => string.IsNullOrEmpty(SelectedItem) ? "" : "Selected Item: " + SelectedItem;
        List<string> countries = new List<string>
        {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"
        };
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
