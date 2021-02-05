using OsMobile.iOS.Renderers;
using OsMobile.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RemoveUnderLinePicker), typeof(RemoveUnderLinePickerRenderer))]
namespace OsMobile.iOS.Renderers
{
    public class RemoveUnderLinePickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null)
                return;
            Control.Layer.BorderWidth = 1;
            Control.Layer.BorderColor = Color.Transparent.ToCGColor();
        }

    }
}
