namespace PrismCore.ViewModel
{
    using Prism.Commands;
    using Prism.Navigation;
    using PrismCore.Helper;
    using PrismCore.Model;
    using PrismCore.Page;
    using PrismCore.Service;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class CountriesViewModel : ViewModelBase
    {
        private readonly CountryService _countryService;
        private ObservableCollection<Country> _countries;
        private ObservableCollection<Country> CountryLocal;
        private bool _isRefreshing;
        private string _filter;

        public CountriesViewModel(INavigationService navigationService, CountryService countryService)
            : base(navigationService)
        {
            Title = "Countries Of American";
            this._countryService = countryService;
            GetCountries();
        }

        public ObservableCollection<Country> Countries
        {
            get => _countries;
            set => SetProperty(ref _countries, value);
        }

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }

        public string Filter
        {
            get => _filter;
            set
            {
                SetProperty(ref _filter, value);
                Search();
            }
        }

        public DelegateCommand RefreshCommand => new DelegateCommand(Refresh);

        public DelegateCommand SearchCommand => new DelegateCommand(Search);

        public ICommand LandTapCommand => new Command(LandTap);

        private async void LandTap(object obj)
        {
            var land = obj as Country;
            await NavigationService.NavigateAsync($"{nameof(LandPage)}", (Constant.KeyParamCountry, land));
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(Filter))
            {
                Countries = CountryLocal;
            }
            else
            {
                Countries = new ObservableCollection<Country>(
                    CountryLocal.Where(c => c.Name.ToLower().Contains(Filter.ToLower()) || c.Capital.ToLower().Contains(Filter.ToLower())));
            }
        }

        private async void Refresh()
        {
            await GetCountries();
        }

        private async Task GetCountries()
        {
            IsRefreshing = true;
            var countries = await _countryService.GetCountry(this);
            CountryLocal = new ObservableCollection<Country>(countries);
            Countries = CountryLocal;
            IsRefreshing = false;
        }
    }
}
