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
        private string OauthKey;
        private string CfidKey;
        public Scope Scope { get; set; }

        public MainWindow()
        {
            _bassNetService = new BassNetService();
            _spotifyService = new SpotifyService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var albumTracks = _spotifyService.GetAlbumTracks();
            if(albumTracks == null || albumTracks.Items.Count == 0)
            {
                return;
            }
            var albumTracksUrls = new List<string>(); 
            foreach(var albumTrack in albumTracks.Items)
            {
                albumTracksUrls.Add(albumTrack.PreviewUrl);
            }
            _bassNetService.CallBassNetRegistration();

            _bassNetService.Play();
        }
    }
}
