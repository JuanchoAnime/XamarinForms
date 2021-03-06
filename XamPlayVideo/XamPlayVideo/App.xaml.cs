namespace XamPlayVideo
{
    using Xamarin.Forms;
    using XamPlayVideo.Pages;
    using XamPlayVideo.Service;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<PelisService>();
            MainPage = new NavigationPage(new WatchListPage());
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
    }
}
