namespace PruebaUI3
{
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "SwipeView_Experimental", "Shapes_Experimental", "MediaElement_Experimental" });
            MainPage = new NavigationPage(new Page.LoginPage());
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
