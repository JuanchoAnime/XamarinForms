using AgoraVideoCall.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Xamarin.Forms.MasterDetailPage
    {
        private readonly Dictionary<int, NavigationPage> _menuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
            _menuPages.Add((int)MenuItemType.Call, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (Device.RuntimePlatform == Device.macOS && id == (int)MenuItemType.About)
            {
                DisplayAlert("About",
@"Xamarin.Forms sample for Agora SDK
Proudly presented by Agora and DreamTeam Mobile
https://agora.io
https://drmtm.us", "OK");
                return;

            }
            if (!_menuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Call:
                        _menuPages.Add(id, new NavigationPage(new ConnectPage()));
                        break;
                    case (int)MenuItemType.About:
                        _menuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            NavigationPage newPage = _menuPages[id];
            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;
                if (Device.RuntimePlatform == Device.Android)
                {
                    await Task.Delay(100); //auto-hide menu on Android
                }
                IsPresented = false;
            }
        }
    }
}