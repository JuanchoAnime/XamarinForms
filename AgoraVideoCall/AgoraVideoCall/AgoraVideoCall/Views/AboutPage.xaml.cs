using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void LinkButtonClicked(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (Uri.IsWellFormedUriString(button?.Text, UriKind.Absolute))
            {
                Device.OpenUri(new Uri(button?.Text, UriKind.Absolute));
            }
        }
    }
}