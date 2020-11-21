namespace Lands.Servicios
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Models;
    using Plugin.Connectivity;

    public class ApiService : IApiService
    {
        public async Task<Response> CheckInternet()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response() { IsSuccess = false, Message = "Por Favor active su conexión a intenernet" };
            }

            bool isrecheable = await CrossConnectivity.Current.IsRemoteReachable("google.com");
            if (!isrecheable)
            {
                return new Response() { IsSuccess = false, Message = "No tiene conexión a internet" };
            }
            return new Response() { IsSuccess = true };
        }

        public async Task<Response> GetList<T>(string url, string prefix, string controller)
        {
            try
            {
                HttpClient client = new HttpClient { BaseAddress = new Uri(url) };
                string urlfinal = $"/{prefix}/{controller}";
                HttpResponseMessage response = await client.GetAsync(urlfinal);

                string answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response { IsSuccess = false, Message = answer };
                }

                return new Response { IsSuccess = true, Result = JsonConvert.DeserializeObject<List<T>>(answer) };
            }
            catch (Exception ex)
            {
                return new Response { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
