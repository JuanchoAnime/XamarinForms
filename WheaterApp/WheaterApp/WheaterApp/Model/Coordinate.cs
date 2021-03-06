namespace WheaterApp.Model
{
    using Newtonsoft.Json;

    public class Coordinate
    {
        [JsonProperty("lat")]
        public double Latitud { get; set; }

        [JsonProperty("lon")]
        public double Longitud { get; set; }
    }
}
