using System.Collections.Generic;
using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class SeveralAlbums : BasicModel
    {
        [JsonProperty("albums")]
        public List<FullAlbum> Albums { get; set; }
    }
}