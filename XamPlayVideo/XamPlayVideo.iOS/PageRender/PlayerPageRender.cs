using Foundation;
using Xamarin.Forms;
using XamPlayVideo.iOS.PageRender;
using XamPlayVideo.Pages;

[assembly: ExportRenderer(typeof(PlayerPage), typeof(PlayerPageRender))]
namespace XamPlayVideo.iOS.PageRender
{
    using UIKit;
    using Xamarin.Forms.Platform.iOS;

    public class PlayerPageRender : PageRenderer
    {
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)(UIInterfaceOrientation.Portrait)), new NSString("orientation"));
        }
    }
}