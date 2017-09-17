using System.Collections.Generic;
using Newtonsoft.Json;


namespace MixingApp.Services.SpotifyWeb.Models
{
    public class AvailabeDevices : BasicModel
    {
        [JsonProperty("devices")]
        public List<Device> Devices { get; set; }
    }
}