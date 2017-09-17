using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class FollowedArtists : BasicModel
    {
        [JsonProperty("artists")]
        public CursorPaging<FullArtist> Artists { get; set; }
    }
}