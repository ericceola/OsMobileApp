using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using OsMobile.Droid.Renderers;
using OsMobile.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RemoveUnderLinePicker), typeof(RemoveUnderLinePickerRenderer))]
namespace OsMobile.Droid.Renderers
{
    public class RemoveUnderLinePickerRenderer : PickerRenderer
    {
        private Context context;
        public RemoveUnderLinePickerRenderer(Context context) : base(context)
        {
            this.context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
       {
        base.OnElementChanged(e);
        if (Control == null || e.NewElement == null) return;
        //for example ,change the line to red:
        if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
        else
            Control.Background.SetColorFilter(Android.Graphics.Color.Transparent, PorterDuff.Mode.SrcAtop);
       }
    }
}
