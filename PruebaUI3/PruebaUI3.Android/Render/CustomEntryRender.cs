
using Android.Content;
using PruebaUI3.Droid.Render;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRender))]
namespace PruebaUI3.Droid.Render
{
    public class CustomEntryRender : EntryRenderer
    {
        public CustomEntryRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null) Control.Background = null;
        }
    }
}