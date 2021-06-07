using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using RESTAPP.iOS.Picker;
using RESTAPP.Model.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace RESTAPP.iOS.Picker
{
    class CustomPickerRenderer : PickerRenderer
    {
        private NSCoder downarrow;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Picker> e)
        {
            base.OnElementChanged(e);
            var element = (CustomPicker)this.Element;
            if(this.Control !=null && this.Element!=null && !string.IsNullOrEmpty(element.Icon))
            {
                Control.RightViewMode = UITextFieldViewMode.Always;
                Control.RightView = new UIImageView(downarrow);
            }
        }
    }
}