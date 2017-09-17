using MixingApp.Services.SpotifyWeb;
using System;

namespace MixingApp.Services.SpotifyWeb.Models.Enums
{
    [Flags]
    public enum FollowType
    {
        [String("artist")]
        Artist = 1,

        [String("user")]
        User = 2
    }
}