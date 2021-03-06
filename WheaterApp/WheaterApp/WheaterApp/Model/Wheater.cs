namespace WheaterApp.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Wheater
    {
        [JsonProperty("cod")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        
        [JsonProperty("cnt")]
        public int Cnt { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("list")]
        public List<Temperatures> Temperatures { get; set; }

        public string DayNow { get; set; }
    }
}
