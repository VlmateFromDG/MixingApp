using MixingApp.Services.SpotifyWeb;
using System;

namespace MixingApp.Services.SpotifyWeb.Models.Enums
{
    [Flags]
    public enum RepeatState
    {
        [String("track")]
        Track = 1,

        [String("context")]
        Context = 2,

        [String("off")]
        Off = 4
    }
}