namespace PrismCore.ViewModel
{
    using Prism.Navigation;

    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Login";
        }
    }
}
