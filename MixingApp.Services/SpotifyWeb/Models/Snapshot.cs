using Newtonsoft.Json;
using System;

namespace MixingApp.Services.SpotifyWeb.Models
{
    public class Snapshot : BasicModel
    {
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }
    }
}