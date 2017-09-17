
using Newtonsoft.Json;
using SpotifyAPI.Local;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Mix;
using MixingApp.Services;

namespace MixingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private BassNetService _bassNetService;
        private SpotifyService _spotifyService;
        private string ClientId = "385f6403c4424a7aa4700704f3dd5284";
        private string ClientSecret = "9cdac36957504632b2651e7a4c477f2e";
        private string OauthKey;
        private string CfidKey;
        private SpotifyLocalAPIConfig _config;
        public Scope Scope { get; set; }

        public MainWindow()
        {
            _bassNetService = new BassNetService();
            _spotifyService = new SpotifyService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _spotifyService.GetLinksSongs();
            //var urlTrack = new List<string>();
            //urlTrack.Add("https://open.spotify.com/track/2TpxZ7JUBn3uw46aR7qd6V");
            //urlTrack.Add("https://open.spotify.com/track/4PjcfyZZVE10TFd9EKA72r");
            //urlTrack.Add("https://open.spotify.com/track/2tniUNfN0hmqavFuJ2NodO");

            //urlTrack.Add("https://p.scdn.co/mp3-preview/12b8cee72118f995f5494e1b34251e4ac997445e?cid=8897482848704f2a8f8d7c79726a70d4");
            //urlTrack.Add("https://p.scdn.co/mp3-preview/4a54d83c195d0bc17b1b23fc931d37fb363224d8?cid=8897482848704f2a8f8d7c79726a70d4");
            //urlTrack.Add("https://p.scdn.co/mp3-preview/fce49876156ffb50ecc873e0fc7e1714bc03f10b?cid=8897482848704f2a8f8d7c79726a70d4");

            _bassNetService.CallBassNetRegistration();

            _bassNetService.Play();
        }
    }
}
