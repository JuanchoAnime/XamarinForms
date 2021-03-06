namespace XamGMaps.iOS
{
    using Foundation;
    using UIKit;
    using XamGMaps.Constants;

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Xamarin.FormsGoogleMaps.Init(Variables.GoogleMapsApiKey);
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
