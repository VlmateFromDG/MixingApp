using Newtonsoft.Json;
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
using SpotifyAPI.Web.Enums;

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

        public MainWindow()
        {
            _bassNetService = new BassNetService();
            _spotifyService = new SpotifyService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var albumTracks = _spotifyService.GetAlbumTracks();
            if (albumTracks == null || albumTracks.Items.Count == 0)
            {
                return;
            }
            var albumTracksUrls = new List<string>();
            foreach (var albumTrack in albumTracks.Items)
            {
                albumTracksUrls.Add(albumTrack.PreviewUrl);
            }
            _bassNetService.CallBassNetRegistration();
            //TestSetUrls(albumTracksUrls);
            _bassNetService.Play(albumTracksUrls);
        }

        private static void TestSetUrls(List<string> albumTracksUrls)
        {
            albumTracksUrls.Add("https://p.scdn.co/mp3-preview/12b8cee72118f995f5494e1b34251e4ac997445e?cid=8897482848704f2a8f8d7c79726a70d4");
            albumTracksUrls.Add("https://p.scdn.co/mp3-preview/4a54d83c195d0bc17b1b23fc931d37fb363224d8?cid=8897482848704f2a8f8d7c79726a70d4");
            albumTracksUrls.Add("https://p.scdn.co/mp3-preview/fce49876156ffb50ecc873e0fc7e1714bc03f10b?cid=8897482848704f2a8f8d7c79726a70d4");
        }
    }
}
