namespace PruebasUi2
{
    using Plugin.AppShortcuts;
    using Plugin.AppShortcuts.Icons;
    using PruebasUi2.Page;
    using PruebasUi2.ViewModel;
    using System;
    using System.Linq;
    using Xamarin.Forms;

    public partial class App : Application
    {
        public const string AppShortcutUriBase = "asfs://pruebaui/";
        public const string ShortcutOption1 = "carousel";
        public const string ShortcutOption2 = "login";

        public App()
        {
            AddShortcuts();
            InitializeComponent();
            MainViewModel.INSTANCE.Carousel = new CarouselViewModel();
            MainPage = new Page.CarouselPage();
        }
        async void AddShortcuts()
        {
            if (CrossAppShortcuts.IsSupported)
            {
                var shortCurts = await CrossAppShortcuts.Current.GetShortcuts();
                
                if (shortCurts.FirstOrDefault(prop => prop.Label.Equals("carousel")) == null)
                {
                    await CrossAppShortcuts.Current.AddShortcut(new Shortcut() {
                        Label = "carousel",
                        Description = "Go to Carousel",
                        Icon = new ContactIcon(),
                        Uri = $"{AppShortcutUriBase}{ShortcutOption1}"
                    });
                }
                if (shortCurts.FirstOrDefault(prop => prop.Label.Equals("login")) == null)
                {
                    await CrossAppShortcuts.Current.AddShortcut(new Shortcut() {
                        Label = "login",
                        Description = "Go to Login",
                        Icon = new UpdateIcon(),
                        Uri = $"{AppShortcutUriBase}{ShortcutOption2}"
                    });
                }
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            var option = uri.ToString().Replace(AppShortcutUriBase, "");
            if (!string.IsNullOrEmpty(option)) { 
                switch (option)
                {
                    case ShortcutOption1:
                        MainViewModel.INSTANCE.Carousel = new CarouselViewModel();
                        MainPage = new Page.CarouselPage();
                        break;
                    case ShortcutOption2:
                        MainViewModel.INSTANCE.Login = new LoginViewModel();
                        App.Current.MainPage = new LoginPage();
                        break;
                }
            }
            else
                base.OnAppLinkRequestReceived(uri);
        }
    }
}
