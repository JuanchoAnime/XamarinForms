namespace Lands.Models
{
    using Lands.Helpers;
    using Newtonsoft.Json;
    using Prism.Commands;
    using Prism.Navigation;

    public class CountryExt: Country
    {
        private readonly INavigationService _navigation;
        private DelegateCommand _gotoCountryAsync;

        public CountryExt(INavigationService navigation)
        {
            this._navigation = navigation;
        }

        public DelegateCommand GotoCountryAsync
        {
            get => this._gotoCountryAsync ?? (this._gotoCountryAsync = new DelegateCommand(this.GotoLand));
        }

        private void GotoLand()
        {
            var countries = new Country()
            {
                Alpha2Code = this.Alpha2Code, Alpha3Code = this.Alpha3Code,
                AltSpellings = this.AltSpellings, Area = this.Area,
                Borders = this.Borders, CallingCodes = this.CallingCodes,
                Capital = this.Capital, Cioc = this.Cioc,
                Currencies = this.Currencies, Demonym = this.Demonym,
                Flag = this.Flag, Gini = this.Gini,
                Languages = this.Languages, Latlng = this.Latlng,
                Name = this.Name, NativeName = this.NativeName,
                NumericCode = this.NumericCode, Population = this.Population,
                Region = this.Region, RegionalBlocs = this.RegionalBlocs,
                Subregion = this.Subregion, Timezones = this.Timezones,
                TopLevelDomain = this.TopLevelDomain, Translations = this.Translations
            };
            Settings.Land = JsonConvert.SerializeObject(countries);
            
            this._navigation.NavigateAsync("LandTabbedPage");
        }
    }
}
