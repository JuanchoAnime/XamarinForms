using PruebaUI.Pages;
using PruebaUI.Service;
using PruebaUI.ViewModels;
using Xamarin.Forms;

namespace PruebaUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<DataService>();
            MainViewModel.INSTANCE.FIngerPrint = new FIngerPrintViewModel();
            MainPage = new FingerPrintPage();
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
