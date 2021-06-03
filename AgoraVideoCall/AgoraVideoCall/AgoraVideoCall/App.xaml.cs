using AgoraVideoCall.Views;
using Xamarin.Forms;

namespace AgoraVideoCall
{
    public partial class App : Application
    {
        public static string KeyApi = "";

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
