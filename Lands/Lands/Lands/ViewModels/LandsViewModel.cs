namespace Lands.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Lands.Helpers;
    using Lands.Models;
    using Lands.Servicios;
    using Newtonsoft.Json;
    using Prism.Commands;
    using Prism.Navigation;
    using Prism.Services;

    public class LandsViewModel: BaseViewModel
    {
        #region Atributes

        private readonly INavigationService _navigation;
        private readonly IApiService _api;
        private readonly IPageDialogService _pageDialog;
        private ObservableCollection<CountryExt> _countries;
        private string _search;
        private DelegateCommand _searchCommand;
        private bool _isrefreshing;
        private DelegateCommand _refreshCommand;

        #endregion

        #region Constructor

        public LandsViewModel( INavigationService navigation, IApiService api, IPageDialogService pageDialog) : base(navigation)
        {
            this.Search = string.Empty;
            this.Title = "Countries";
            this._navigation = navigation;
            this._api = api;
            this._pageDialog = pageDialog;
            this.LoadCountriesAsync();
        }

        #endregion

        #region Properties

        public DelegateCommand RefreshCommand
        {
            get => this._refreshCommand ?? (this._refreshCommand = new DelegateCommand(this.LoadCountriesAsync));
        }

        public bool IsRefreshing
        {
            get => this._isrefreshing;
            set => this.SetProperty(ref this._isrefreshing, value);
        }

        public DelegateCommand SearchCommand
        {
            get => this._searchCommand ?? (this._searchCommand = new DelegateCommand(this.RefreshList));
        }

        public List<Country> MysCountries { get; set; }

        public ObservableCollection<CountryExt> Countries
        {
            get => this._countries;
            set => this.SetProperty(ref this._countries, value);
        }

        public string Search
        {
            get => this._search;
            set => this.SetProperty(ref this._search, value);
        }

        #endregion

        #region Methods

        private async void LoadCountriesAsync()
        {
            this.IsRefreshing = true;
            var response = await this._api.CheckInternet();
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await this._pageDialog.DisplayAlertAsync("Error", response.Message, "OK");
                return;
            }

            response = await this._api.GetList<Country>("https://restcountries.eu", "rest", "v2/all");
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await this._pageDialog.DisplayAlertAsync("Error", response.Message, "OK");
                return;
            }

            this.MysCountries = (List<Country>)response.Result;
            Settings.Lands = JsonConvert.SerializeObject(this.MysCountries);
            this.RefreshList();
            this.IsRefreshing = false;
        }

        private void RefreshList()
        {

            var list = this.MysCountries.Select(
                c => new CountryExt (_navigation)
                {
                    Alpha2Code = c.Alpha2Code,
                    Alpha3Code = c.Alpha3Code,
                    AltSpellings = c.AltSpellings,
                    Area = c.Area,
                    Borders = c.Borders,
                    CallingCodes = c.CallingCodes,
                    Capital = c.Capital,
                    Cioc = c.Cioc,
                    Currencies = c.Currencies,
                    Demonym = c.Demonym,
                    Flag = c.Flag,
                    Gini = c.Gini,
                    Languages = c.Languages,
                    Latlng = c.Latlng,
                    Name = c.Name,
                    NativeName = c.NativeName,
                    NumericCode = c.NumericCode,
                    Population = c.Population,
                    Region = c.Region,
                    RegionalBlocs = c.RegionalBlocs,
                    Subregion = c.Subregion,
                    Timezones = c.Timezones,
                    TopLevelDomain = c.TopLevelDomain,
                    Translations = c.Translations
                }).ToList();

            if (string.IsNullOrEmpty(this.Search))
            {
                this.Countries = new ObservableCollection<CountryExt>(list.OrderBy(c=>c.Name).ToList());
            }
            else
            {
                this.Countries = new ObservableCollection<CountryExt>(list.Where(c => c.Name.ToUpper().Contains(this.Search.ToUpper())).OrderBy(c=>c.Name).ToList());
            }
            
        }

        #endregion

    }
}
