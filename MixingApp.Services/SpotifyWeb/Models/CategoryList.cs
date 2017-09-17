using Newtonsoft.Json;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class CategoryList : BasicModel
    {
        [JsonProperty("categories")]
        public Paging<Category> Categories { get; set; }
    }
}