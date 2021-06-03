using Foundation;
using UIKit;

namespace PruebasUi2.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Rg Popup
            Rg.Plugins.Popup.Popup.Init();
            global::Xamarin.Forms.Forms.Init();
         
            //Carousel View
            CarouselView.FormsPlugin.iOS.CarouselViewRenderer.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        // Shourcut Plugin.AppShortcut
        public override void PerformActionForShortcutItem(UIApplication application, UIApplicationShortcutItem shortcutItem, UIOperationHandler completionHandler)
        {
            var uri = Plugin.AppShortcuts.iOS.ArgumentsHelper.GetUriFromApplicationShortcutItem(shortcutItem);
            if (uri != null)
            {
                Xamarin.Forms.Application.Current.SendOnAppLinkRequestReceived(uri);
            }
        }
    }
}
