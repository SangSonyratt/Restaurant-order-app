using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RESTAPP.Droid.Picker;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePicker))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace RESTAPP.Droid.Picker
{
    [Obsolete]
    public class CustomTimePicker : ViewRenderer<Xamarin.Forms.TimePicker, Android.Widget.EditText>, TimePickerDialog.IOnTimeSetListener, IJavaObject, IDisposable
    {
        private TimePickerDialog dialog = null;

        public string Image { get; internal set; }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.TimePicker> e)
        {
            base.OnElementChanged(e);
            this.SetNativeControl(new Android.Widget.EditText(Forms.Context));
            this.Control.Click += Control_Click;
            this.Control.Text = DateTime.Now.ToString("HH:mm tt");
            this.Control.KeyListener = null;
            this.Control.FocusChange += Control_FocusChange;
        }

        public static explicit operator CustomTimePicker(Xamarin.Forms.Picker v)
        {
            throw new NotImplementedException();
        }

        void Control_FocusChange(object sender, FocusChangeEventArgs e)
        {
            if(e.HasFocus)
            {
                ShowTimePicker();
            }
        }

        void Control_Click(object sender, EventArgs e)
        {
            ShowTimePicker();
        }

        private void ShowTimePicker()
        {
            if(dialog == null)
            {
                dialog = new TimePickerDialog(Forms.Context, this, DateTime.Now.Hour, DateTime.Now.Minute, true);
            }
            dialog.Show();
        }

        public void OnTimeSet(Android.Widget.TimePicker view, int hourOfDay, int minute)
        {
            var time = new TimeSpan(hourOfDay, minute, 0);
            this.Element.SetValue(Xamarin.Forms.TimePicker.TimeProperty, time);
            Control.Text = time.ToString(@"hh\:mm");
        }
    }
}