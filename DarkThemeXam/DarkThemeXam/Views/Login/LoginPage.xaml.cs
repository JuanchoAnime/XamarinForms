namespace DarkThemeXam.Views.Login
{
    using DarkThemeXam.Views.Dashboard;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButtomPressed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardPage());
        }

        private async void ChangeTheme_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}