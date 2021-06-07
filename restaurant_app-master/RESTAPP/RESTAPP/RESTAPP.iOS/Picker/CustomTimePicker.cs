using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using RESTAPP.iOS.Picker;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePicker))]
namespace RESTAPP.iOS.Picker
{
    public class CustomTimePicker : TimePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            var timePicker = (UIDatePicker)Control.InputView;
            timePicker.Locale = new NSLocale("no_nb");
            if(Control!=null)
            {
                Control.Text = DateTime.Now.ToString("HH:mm tt");
            }
        }
    }
}