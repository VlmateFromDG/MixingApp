using System.Collections.Generic;
using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class SeveralArtists : BasicModel
    {
        [JsonProperty("artists")]
        public List<FullArtist> Artists { get; set; }
    }
}