using System.Collections.Generic;
using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class SeveralTracks : BasicModel
    {
        [JsonProperty("tracks")]
        public List<FullTrack> Tracks { get; set; }
    }
}