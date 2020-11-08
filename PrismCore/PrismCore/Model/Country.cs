namespace PrismCore.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Collections.Generic;

    public class Currency
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }

    public class Language
    {
        [JsonProperty(PropertyName = "iso639_1")]
        public string Iso1 { get; set; }

        [JsonProperty(PropertyName = "iso639_2")]
        public string Iso2 { get; set; }

        public string Name { get; set; }

        public string NativeName { get; set; }
    }

    public class Translations
    {
        [JsonProperty(PropertyName = "de")]
        public string Germany { get; set; }

        [JsonProperty(PropertyName = "es")]
        public string Spanish { get; set; }

        [JsonProperty(PropertyName = "fr")]
        public string French { get; set; }

        [JsonProperty(PropertyName = "ja")]
        public string Japanese { get; set; }

        [JsonProperty(PropertyName = "it")]
        public string Italian { get; set; }

        [JsonProperty(PropertyName = "br")]
        public string Brazilian { get; set; }

        [JsonProperty(PropertyName = "pt")]
        public string Portugues { get; set; }

        [JsonProperty(PropertyName = "nl")]
        public string Dutch { get; set; }

        [JsonProperty(PropertyName = "hr")]
        public string Croatian { get; set; }

        [JsonProperty(PropertyName = "fa")]
        public string Danish { get; set; }
    }

    public class RegionalBloc
    {
        public string Acronym { get; set; }
        
        public string Name { get; set; }
        
        public List<string> OtherAcronyms { get; set; }
        
        public List<string> OtherNames { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }

        public List<string> TopLevelDomain { get; set; }

        public string Alpha2Code { get; set; }

        public string Alpha3Code { get; set; }

        public List<string> CallingCodes { get; set; }

        public string Capital { get; set; }

        public List<string> AltSpellings { get; set; }
        
        public string Region { get; set; }
        
        public string Subregion { get; set; }
        
        public int Population { get; set; }
        
        public List<double> Latlng { get; set; }
        
        public string Demonym { get; set; }
        
        public double? Area { get; set; }
        
        public double? Gini { get; set; }
        
        public List<string> Timezones { get; set; }
        
        public List<string> Borders { get; set; }
        
        public string NativeName { get; set; }
        
        public string NumericCode { get; set; }
        
        public List<Currency> Currencies { get; set; }
        
        public List<Language> Languages { get; set; }
        
        public Translations Translations { get; set; }
        
        public string Flag { get; set; }
        
        public List<RegionalBloc> RegionalBlocs { get; set; }
        
        public string Cioc { get; set; }
    }
}
