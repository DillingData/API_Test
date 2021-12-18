﻿using Newtonsoft.Json;

namespace ApiPlayground.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Coordinates
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

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

    public class Main
    {
        [JsonProperty("temp")]
        public double temp { get; set; }
        [JsonProperty("feels_like")]
        public double feels_like { get; set; }
        [JsonProperty("temp_min")]
        public double temp_min { get; set; }
        [JsonProperty("temp_max")]
        public double temp_max { get; set; }
        [JsonProperty("pressure")]
        public int pressure { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double speed { get; set; }
        [JsonProperty("deg")]
        public int deg { get; set; }
        [JsonProperty("gust")]
        public double gust { get; set; }
    }

    public class Clouds
    {
        [JsonProperty("all")]
        public int all { get; set; }
    }

    public class Sys
    {
        [JsonProperty("type")]
        public int type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("sunrise")]
        public int sunrise { get; set; }
        [JsonProperty("sunset")]
        public int sunset { get; set; }
    }

    public class Root
    {
        [JsonProperty("coord")]
        public Coordinates coord { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
        [JsonProperty("@base")]
        public string @base { get; set; }
        [JsonProperty("main")]
        public Main main { get; set; }
        [JsonProperty("visibility")]
        public int visibility { get; set; }
        [JsonProperty("wind")]
        public Wind wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds clouds { get; set; }
        [JsonProperty("dt")]
        public int dt { get; set; }
        [JsonProperty("sys")]
        public Sys sys { get; set; }
        [JsonProperty("timezone")]
        public int timezone { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("cod")]
        public int cod { get; set; }
    }


}
