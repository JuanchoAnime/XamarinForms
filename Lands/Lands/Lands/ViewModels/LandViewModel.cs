namespace Lands.ViewModels
{
    using Lands.Helpers;
    using Lands.Models;
    using Newtonsoft.Json;
    using Prism.Navigation;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class LandViewModel : BaseViewModel
    {
        #region Atributes

        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        private ObservableCollection<Language> languages;
        private Country _land;
        private Translations _translations;

        #endregion

        #region Properties

        public Translations Translations
        {
            get => this._translations;
            set => this.SetProperty(ref this._translations, value);
        }

        public Country Land
        {
            get => this._land;
            set => this.SetProperty(ref this._land, value);
        }

        public ObservableCollection<Language> Languages
        {
            get => this.languages;
            set => this.SetProperty(ref this.languages, value);
        }
        public ObservableCollection<Currency> Currencies
        {
            get => this.currencies;
            set => this.SetProperty(ref this.currencies, value);
        }
        public ObservableCollection<Border> Borders
        {
            get => this.borders;
            set => this.SetProperty(ref this.borders, value);
        }

        #endregion

        #region Constructor

        public LandViewModel(INavigationService navigation) : base(navigation)
        {
        }

        #endregion

        #region ElementsOverride

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            this.Land = JsonConvert.DeserializeObject<Country>(Settings.Land);
            this.Languages = new ObservableCollection<Language>(this.Land.Languages);
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);
            this.Translations = this.Land.Translations;
            this.Borders = new ObservableCollection<Border>();
            this.LoadCountriesAsync();
        }

        #endregion

        #region Methods

        private void LoadCountriesAsync()
        {
            var mysCountries = JsonConvert.DeserializeObject<List<Country>>(Settings.Lands);
            this.Land.Borders.Cast<string>().ToList().ForEach(
                borders =>
                {
                    var land = mysCountries.Where(l => l.Alpha3Code == borders).FirstOrDefault();
                    if (land != null)
                    {
                        this.Borders.Add(new Border
                        {
                            Code = land.Alpha3Code,
                            Name = land.Name
                        });
                    }
                }
            );
        }

        #endregion
    }
}
