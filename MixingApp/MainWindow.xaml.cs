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
            _bassNetService.Play(albumTracksUrls);
        }
    }
}
