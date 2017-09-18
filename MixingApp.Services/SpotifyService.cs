using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MixingApp.Services
{
    public class SpotifyService
    {
        private string ClientId = "385f6403c4424a7aa4700704f3dd5284";
        private string ClientSecret = "9cdac36957504632b2651e7a4c477f2e";
        public Scope Scope { get; set; }
        public SpotifyService()
        {

        }

        public Paging<SimpleTrack> GetAlbumTracks()
        {
            var auth = new SpotifyAPI.Web.Auth.ClientCredentialsAuth();
            auth.ClientId = ClientId;
            auth.ClientSecret = ClientSecret;
            var authValue = auth.DoAuth();
            var SpotifyWebAPI = new SpotifyWebAPI();
            SpotifyWebAPI.AccessToken = authValue.AccessToken;
            SpotifyWebAPI.TokenType = authValue.TokenType;
            SpotifyWebAPI.UseAuth = true;
            var albumTracks = SpotifyWebAPI.GetAlbumTracks("6akEvsycLGftJxYudPjmqK", 3, 0, "");
            return albumTracks;
        }
    }
}
