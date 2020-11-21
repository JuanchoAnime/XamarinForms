namespace Lands.Servicios
{
    using System.Threading.Tasks;
    using Lands.Models;

    public interface IApiService
    {
        Task<Response> CheckInternet();

        Task<Response> GetList<T>(string url, string prefix, string controller);
    }
}