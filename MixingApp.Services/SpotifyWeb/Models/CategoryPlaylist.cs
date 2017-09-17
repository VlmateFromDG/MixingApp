using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class CategoryPlaylist : BasicModel
    {
        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}