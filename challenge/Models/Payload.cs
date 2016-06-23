using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace challenge.Models
{
    public class Show
    {
        public string Country { get; set; }
        public string Description { get; set; }        
        public bool Drm { get; set; }
        public int EpisodeCount { get; set; }
        public string Genre { get; set; }
        public PayloadImage Image { get; set; }
        public string Language { get; set; }
        public string PrimaryColour { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string Slug { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }
        [JsonProperty(Required = Required.Always)]
        public string TvChannel { get; set; }
    }

    public class PayloadImage
    {
        [JsonProperty(Required = Required.Always)]
        public string ShowImage { get; set; }
    }

    public class Season
    {
        public string Slug { get; set; }
    }

    public class PayloadSummary
    {
        [JsonProperty(Required = Required.Always)]
        public IList<Show> Payload { get; set; }
        [JsonProperty(Required = Required.Always)]
        public int Skip { get; set; }
        [JsonProperty(Required = Required.Always)]
        public int TotalRecords { get; set; }
    }

}