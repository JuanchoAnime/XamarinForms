using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Extensions;
using System.Windows.Input;

namespace PruebasUi2.ViewModel
{
    public class MessageBoxViewModel : BaseViewModel
    {
        public ICommand CloseCommand => new RelayCommand(this.Close);

        public void CloseModal() => this.Close();

        public string Mensaje { get; set; }

        public MessageBoxViewModel(string mensaje)
        {
            this.Mensaje = mensaje;
        }

        private void Close()
        {
            App.Current.MainPage.Navigation.PopPopupAsync(true);
        }
    }
}
