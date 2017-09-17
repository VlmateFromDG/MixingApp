using System.Collections.Generic;
using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class RecommendationSeedGenres : BasicModel
    {
         [JsonProperty("genres")]
         public List<string> Genres { get; set; }
    }
}