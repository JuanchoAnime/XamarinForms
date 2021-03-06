namespace XamPlayVideo.iOS
{
    using Foundation;
    using LibVLCSharp.Forms.Shared;
    using System.Linq;
    using UIKit;
    using XamPlayVideo.Pages;

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            LibVLCSharpFormsRenderer.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            var mainPage = Xamarin.Forms.Application.Current.MainPage;
            if (mainPage.Navigation.NavigationStack.Last() is PlayerPage)
            {
                return UIInterfaceOrientationMask.Landscape;
            }
            return UIInterfaceOrientationMask.Portrait;
        }
    }
}
