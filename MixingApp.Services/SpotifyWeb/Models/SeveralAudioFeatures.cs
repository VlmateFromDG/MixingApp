using System.Collections.Generic;
using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class SeveralAudioFeatures : BasicModel
    {
         [JsonProperty("audio_features")]
         public List<AudioFeatures> AudioFeatures { get; set; }
    }
}