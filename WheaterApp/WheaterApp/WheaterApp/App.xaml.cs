using WheaterApp.Service;
using WheaterApp.ViewModel;
using Xamarin.Forms;

namespace WheaterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<WheatherDataService>();

            MainPage = new Page.WheaterPage();
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
