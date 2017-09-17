using MixingApp.Services.SpotifyWeb;
using System;

namespace MixingApp.Services.SpotifyWeb.Models.Enums
{
    /// <summary>
    ///     Only one value allowed
    /// </summary>
    [Flags]
    public enum TimeRangeType
    {
        [String("long_term")]
        LongTerm = 1,

        [String("medium_term")]
        MediumTerm = 2,

        [String("short_term")]
        ShortTerm = 4
    }
}