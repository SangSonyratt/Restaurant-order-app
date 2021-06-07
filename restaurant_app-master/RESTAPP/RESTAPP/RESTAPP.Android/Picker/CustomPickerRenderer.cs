using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using RESTAPP.Droid.Picker;
using RESTAPP.Model.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(CustomPicker), target: typeof(CustomPickerRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace RESTAPP.Droid.Picker
{
    [Obsolete]
    class CustomPickerRenderer : PickerRenderer
    {
        CustomPicker element;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Picker> e)
        {
            base.OnElementChanged(e);
            element = (CustomPicker)this.Element;

            if (Control != null && this.Element != null && !string.IsNullOrEmpty(element.Icon))
                Control.Background = AddPickerStyles(element.Icon);
            
        }

        public Drawable AddPickerStyles(string icon)
        {
            ShapeDrawable border = new ShapeDrawable();
            border.Paint.Color = Android.Graphics.Color.White;
            border.SetPadding(10, 10, 10, 10);
            border.Paint.SetStyle(Paint.Style.Stroke);

            Drawable[] layers = { border, GetDrawable(icon) };
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            layerDrawable.SetLayerInset(0, 0, 0, 0, 0);
            return layerDrawable;
        }

        private Drawable GetDrawable(string icon)
        {
            var drawable = Resources.GetDrawable(icon);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, 50, 50, true));
            result.Gravity = Android.Views.GravityFlags.Right;

            return result;
        }
    }
}