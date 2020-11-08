namespace PrismCore.ViewModel
{
    using Prism.Navigation;
    using PrismCore.Helper;
    using PrismCore.Model;

    public class LandViewModel : ViewModelBase
    {
        private Country _country;

        public LandViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }

        public Country Land
        {
            get => _country;
            set => SetProperty(ref _country, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Land = parameters.GetValue<Country>(Constant.KeyParamCountry);
        }
    }
}
