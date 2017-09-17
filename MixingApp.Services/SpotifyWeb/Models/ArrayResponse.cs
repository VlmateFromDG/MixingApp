using System.Collections.Generic;

namespace MixingApp.ViewModels.SpotifyWeb
{
    public class ListResponse<T> : BasicModel
    {
        public List<T> List { get; set; }
    }
}