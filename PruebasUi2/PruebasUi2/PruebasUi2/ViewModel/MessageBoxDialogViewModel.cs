using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Extensions;
using System.Windows.Input;

namespace PruebasUi2.ViewModel
{
    public class MessageBoxDialogViewModel : BaseViewModel
    {
        public ICommand ContinueCommand => new RelayCommand(this.Continue);

        private void Continue()
        {
            App.Current.MainPage.Navigation.PopPopupAsync(true);
        }
    }
}
