using SpotifyAPI.Local;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.IO;

namespace MixingApp.Services
{
    public class SpotifyService
    {
        private string ClientId = "385f6403c4424a7aa4700704f3dd5284";
        private string ClientSecret = "9cdac36957504632b2651e7a4c477f2e";
        private string OauthKey;
        public Scope Scope { get; set; }
        public object JsonConvert { get; private set; }

        public void GetLinksSongs()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("Authorization",
                    "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(ClientId + ":" + ClientSecret)));

                NameValueCollection col = new NameValueCollection
                {
                    {"grant_type", "client_credentials"},
                    {"scope", Scope.GetStringAttribute(" ")}
                };

                byte[] data;
                try
                {
                    data = wc.UploadValues("https://accounts.spotify.com/api/token", "POST", col);
                }
                catch (WebException ex)
                {
                    using (StreamReader reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
                    }
                }
                var token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(Encoding.UTF8.GetString(data));

                OauthKey = token.AccessToken;
            }
        }
    }
}
