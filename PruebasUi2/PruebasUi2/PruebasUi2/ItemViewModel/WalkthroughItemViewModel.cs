using GalaSoft.MvvmLight.Command;
using PruebasUi2.Model;
using PruebasUi2.Page;
using PruebasUi2.ViewModel;
using System.Windows.Input;

namespace PruebasUi2.ItemViewModel
{
    public class WalkthroughItemViewModel: Walkthrough
    {
        public ICommand JumpLoginCommand => new RelayCommand(this.JumpLogin);

        private void JumpLogin()
        {
            MainViewModel.INSTANCE.Login = new LoginViewModel();
            App.Current.MainPage = new LoginPage();
        }
    }
}
