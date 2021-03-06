namespace WheaterApp.Service
{
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Threading.Tasks;
    using WheaterApp.Model;

    public class WheatherDataService : IDataService
    {
        public async Task<Wheater> GetWheater(string city)
        {
            string apiKey = "a75a2e3279fd4174c1958f3cfacc23ab";
            string lang = "es";
            string data = "metric";
            string api = "https://api.openweathermap.org";

            string url = $"{api}/data/2.5/forecast?q={city}&appid={apiKey}&units={data}&lang={lang}";

            var handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);
            string result = await client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<Wheater>(result);

        }
    }
}
