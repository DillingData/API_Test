using Newtonsoft.Json;

namespace ApiPlayground.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    
    public class Weather
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public class Rain
    {
        [JsonProperty("_1h")]
        public double _1h { get; set; }
    }

    public class Current
    {
        [JsonProperty("dt")]
        public string dt { get; set; }
        [JsonProperty("sunrise")]
        public string sunrise { get; set; }
        [JsonProperty("sunset")]
        public string sunset { get; set; }
        [JsonProperty("temp")]
        public double temp { get; set; }
        [JsonProperty("feels_like")]
        public double feels_like { get; set; }
        [JsonProperty("pressure")]
        public string pressure { get; set; }
        [JsonProperty("humidity")]
        public string humidity { get; set; }
        [JsonProperty("dew_point")]
        public double dew_point { get; set; }
        [JsonProperty("uvi")]
        public string uvi { get; set; }
        [JsonProperty("clouds")]
        public string clouds { get; set; }
        [JsonProperty("visibility")]
        public string visibility { get; set; }
        [JsonProperty("wind_speed")]
        public double wind_speed { get; set; }
        [JsonProperty("wind_deg")]
        public string wind_deg { get; set; }
        [JsonProperty("wind_gust")]
        public double wind_gust { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
    }
    
    public class Minutely
    {
        [JsonProperty("dt")]
        public string dt { get; set; }
        [JsonProperty("precipitation")]
        public string precipitation { get; set; }
    }
    
    public class Snow
    {
        [JsonProperty("_1h")]
        public double _1h { get; set; }
    }

    public class Hourly
    {
        [JsonProperty("dt")]
        public string dt { get; set; }
        [JsonProperty("temp")]
        public double temp { get; set; }
        [JsonProperty("feel_like")]
        public double feels_like { get; set; }
        [JsonProperty("pressure")]
        public string pressure { get; set; }
        [JsonProperty("humidity")]
        public string humidity { get; set; }
        [JsonProperty("dew_point")]
        public double dew_point { get; set; }
        [JsonProperty("uvi")]
        public double uvi { get; set; }
        [JsonProperty("clouds")]
        public string clouds { get; set; }
        [JsonProperty("visibility")]
        public string visibility { get; set; }
        [JsonProperty("wind_speed")]
        public double wind_speed { get; set; }
        [JsonProperty("wind_deg")]
        public string wind_deg { get; set; }
        [JsonProperty("wind_gues")]
        public double wind_gust { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
        [JsonProperty("pop")]
        public double pop { get; set; }
        [JsonProperty("snow")]
        public Snow snow { get; set; }
        [JsonProperty("rain")]
        public Rain rain { get; set; }
    }

    public class Temp
    {
        [JsonProperty("day")]
        public double day { get; set; }
        [JsonProperty("min")]
        public double min { get; set; }
        [JsonProperty("max")]
        public double max { get; set; }
        [JsonProperty("night")]
        public double night { get; set; }
        [JsonProperty("eve")]
        public double eve { get; set; }
        [JsonProperty("morn")]
        public double morn { get; set; }
    }

    public class FeelsLike
    {
        [JsonProperty("day")]
        public double day { get; set; }
        [JsonProperty("night")]
        public double night { get; set; }
        [JsonProperty("eve")]
        public double eve { get; set; }
        [JsonProperty("morn")]
        public double morn { get; set; }
    }

    public class Daily
    {
        [JsonProperty("dt")]
        public string dt { get; set; }
        [JsonProperty("sunrise")]
        public string sunrise { get; set; }
        [JsonProperty("sunset")]
        public string sunset { get; set; }
        [JsonProperty("moonrise")]
        public string moonrise { get; set; }
        [JsonProperty("moonset")]
        public string moonset { get; set; }
        [JsonProperty("moon_phase")]
        public double moon_phase { get; set; }
        [JsonProperty("temp")]
        public Temp temp { get; set; }
        [JsonProperty("feels_like")]
        public FeelsLike feels_like { get; set; }
        [JsonProperty("pressure")]
        public string pressure { get; set; }
        [JsonProperty("humidity")]
        public string humidity { get; set; }
        [JsonProperty("dew_point")]
        public double dew_point { get; set; }
        [JsonProperty("wind_speed")]
        public double wind_speed { get; set; }
        [JsonProperty("wind_deg")]
        public string wind_deg { get; set; }
        [JsonProperty("wind_gust")]
        public double wind_gust { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
        [JsonProperty("clouds")]
        public string clouds { get; set; }
        [JsonProperty("pop")]
        public double pop { get; set; }
        [JsonProperty("rain")]
        public double rain { get; set; }
        [JsonProperty("snow")]
        public double snow { get; set; }
        [JsonProperty("uvi")]
        public double uvi { get; set; }
    }

    public class Root
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lon")]
        public double lon { get; set; }
        [JsonProperty("timezone")]
        public string timezone { get; set; }
        [JsonProperty("timezone_offset")]
        public string timezone_offset { get; set; }
        [JsonProperty("current")]
        public Current current { get; set; }
        [JsonProperty("minutely")]
        public List<Minutely> minutely { get; set; }
        [JsonProperty("hourly")]
        public List<Hourly> hourly { get; set; }
        [JsonProperty("daily")]
        public List<Daily> daily { get; set; }
    }
}