namespace PrismCore.Service
{
    using PrismCore.Model;
    using Refit;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICountryApi
    {
        [Get("/all")]
        Task<List<Country>> GetCountries();

        [Get("/region/{region}")]
        Task<List<Country>> GetCountriesByRegion(string region);
    }
}
