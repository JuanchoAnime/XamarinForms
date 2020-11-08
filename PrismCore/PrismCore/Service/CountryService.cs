namespace PrismCore.Service
{
    using PrismCore.Helper;
    using PrismCore.Model;
    using PrismCore.ViewModel;
    using Refit;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CountryService
    {
        public async Task<List<Country>> GetCountry(ViewModelBase viewModelBase)
        {
            var countries = await RestService.For<ICountryApi>(viewModelBase.GetStringForDistionary(Constant.KeyUrlApi))
                                             .GetCountriesByRegion(Constant.RegionCountry);
            return countries;
        }
    }
}
