namespace PruebaUI.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Plugin.Fingerprint;
    using Plugin.Fingerprint.Abstractions;
    using PruebaUI.Pages;
    using System.Windows.Input;

    public class FIngerPrintViewModel : BaseViewModel
    {
        public ICommand VerifyFingerCommand => new RelayCommand(this.VerifyFinger);

        public FIngerPrintViewModel()
        {
            this.VerifyFinger();
        }

        private async void VerifyFinger()
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(true);

            if (result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync(new AuthenticationRequestConfiguration("Coloca tu huella DIgital!",
                    "Para Poder tener acceso"));
                if (auth.Authenticated)
                {
                    MainViewModel.INSTANCE.Wheater = new WheaterViewModel();
                    MainViewModel.INSTANCE.Timer = new TimerViewModel();
                    MainViewModel.INSTANCE.Food = new FoodMainViewModel();
                    App.Current.MainPage = new MainTabPage();

                }
                else {
                    if (string.IsNullOrEmpty(auth.ErrorMessage))
                        await App.Current.MainPage.DisplayAlert("Oops", "Error al Reconocer la huella", "OK");
                    else
                        await App.Current.MainPage.DisplayAlert("Oops", auth.ErrorMessage, "OK");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Oops", "Dispositivo no compatible.", "OK");
            }
        }
    }
}
