namespace WheaterApp.Service
{
    using System.Threading.Tasks;
    using WheaterApp.Model;

    interface IDataService
    {
        Task<Wheater> GetWheater(string city);
    }
}
