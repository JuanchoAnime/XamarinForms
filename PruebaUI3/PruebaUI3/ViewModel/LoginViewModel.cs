using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaUI3.ViewModel
{
    public class LoginViewModel
    {
        public ICommand LoginCommand => new Command(() => App.Current.MainPage.Navigation.PushAsync(new Page.MenuPage()));
    }
}
