namespace XamPlayVideo.Pages
{
    using System.Linq;
    using LibVLCSharp.Shared;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using XamPlayVideo.Model;
    using XamPlayVideo.ViewModel;
    using Xamarin.Essentials;
    using System;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    {
        private readonly LibVLC _libVlc;
        private readonly Movie _selectedMovie;

        public PlayerPage(Movie selectedMovie)
        {
            this._selectedMovie = selectedMovie;
            InitializeComponent();

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                var profiles = Connectivity.ConnectionProfiles;
                if (profiles.Contains(ConnectionProfile.WiFi))
                {
                    Core.Initialize();
                    _libVlc = new LibVLC();
                    var media = new Media(_libVlc,
                        this._selectedMovie.Url,
                        FromType.FromLocation);
                    myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true, Fullscreen = true };
                    myVideo.MediaPlayer.Play();
                }
                else NoWifi("This using movil data", "You are using movil data, wifi activate for view to video");
            }
            else NoWifi("No Internet Connection", "Please Turn off Internet Settings");
        }

        private async void NoWifi(string title, string msg)
        {
            await Application.Current.MainPage.DisplayAlert(title, msg, "Ok");
            this.OnBackButtonPressed();
        }

        protected override bool OnBackButtonPressed()
        {
            if(myVideo.MediaPlayer != null) myVideo.MediaPlayer.Stop();

            return base.OnBackButtonPressed();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "AllowLandscape");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }
    }
}