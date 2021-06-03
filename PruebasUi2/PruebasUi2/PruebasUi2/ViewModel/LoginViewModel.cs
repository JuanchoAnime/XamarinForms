using GalaSoft.MvvmLight.Command;
using Plugin.LocalNotifications;
using PruebasUi2.Page;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PruebasUi2.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        public ICommand LoginCommand => new RelayCommand(this.Login);
        
        public string ImageProfile { get; set; }

        public string ImageGoogle { get; set; }



        public LoginViewModel()
        {
            this.ImageGoogle = "https://s3.us-east-2.amazonaws.com/upload-icon/uploads/icons/png/2630585241548141934-256.png";
            this.ImageProfile = "https://cdn.myanimelist.net/images/userimages/9128492.jpg?t=1587994200";
        }


        private async void Login() 
        {
            MainViewModel.INSTANCE.MessageBox = new MessageBoxViewModel("Espera un momento por favor...");
            var pop = new Component.MessageBox { CloseWhenBackgroundIsClicked = false };
            await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);

            await Task.Delay(2000);

            //Inicializar MainViewModelPrincipales
            MainViewModel.INSTANCE.Profile = new ProfileViewModel();
            MainViewModel.INSTANCE.More = new MoreViewModel();

            // Navigation Drawer
            App.Current.MainPage = new MainPageShellTwo();
            CrossLocalNotifications.Current.Show("Xamarin Latino", "Ingresaste al app satisfactoriamente");
            MainViewModel.INSTANCE.MessageBox.CloseModal();
        }
    }
}
