using GalaSoft.MvvmLight.Command;
using Plugin.LocalNotifications;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Windows.Input;

namespace PruebasUi2.ViewModel
{
    public class MoreViewModel : BaseViewModel
    {
        public ICommand CargandoCommand => new RelayCommand(this.Cargando);

        private async void Cargando()
        {
            MainViewModel.INSTANCE.MessageBoxDialog = new MessageBoxDialogViewModel();
            var pop = new Component.MessageBoxDialog
            {
                CloseWhenBackgroundIsClicked = false
            };
            await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
        }
    }
}
