using Foundation;
using UIKit;

namespace FitnessAppXam.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init();
            Sharpnado.Tabs.iOS.Preserver.Preserve();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
