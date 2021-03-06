namespace XamPlayVideo.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using Android.Runtime;
    using LibVLCSharp.Forms.Shared;
    using Xamarin.Forms;
    using XamPlayVideo.Pages;

    [Activity(Label = "XamPlayVideo", 
        Icon = "@mipmap/icon", 
        Theme = "@style/MainTheme", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);  
            LibVLCSharpFormsRenderer.Init();
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);


            //allowing the device to change the screen orientation based on the rotation 
            MessagingCenter.Subscribe<PlayerPage>(this, "AllowLandscape", sender => {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            //during page close setting back to portrait
            MessagingCenter.Subscribe<PlayerPage>(this, "PreventLandscape", sender => {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}