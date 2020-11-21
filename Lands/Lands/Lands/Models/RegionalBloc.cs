namespace Lands.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RegionalBloc
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otherAcronyms")]
        public List<object> OtherAcronyms { get; set; }

        [JsonProperty("otherNames")]
        public List<object> OtherNames { get; set; }
    }
}
