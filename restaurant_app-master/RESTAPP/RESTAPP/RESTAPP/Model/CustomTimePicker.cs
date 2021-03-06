using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RESTAPP.Model
{
    class CustomTimePicker : TimePicker
    {
        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(CustomTimePicker), string.Empty);
        public string Image
        {
            get
            {
                return (string)GetValue(ImageProperty);
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }
    }
}
