namespace InfiniteScroll.Service
{
    using InfiniteScroll.Model;
    using Refit;
    using System.Threading.Tasks;

    public interface IWaifuService
    {
        [Get("/api/publish?pagenumber={page}")]
        Task<Response> GetWaifus(int page);
    }
}
