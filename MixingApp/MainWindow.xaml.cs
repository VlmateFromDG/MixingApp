
using MixingApp.ViewModels;
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

namespace MixingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private string ClientId = "385f6403c4424a7aa4700704f3dd5284";
        private string ClientSecret = "9cdac36957504632b2651e7a4c477f2e";
        private string OauthKey;
        private string CfidKey;
        private SpotifyLocalAPIConfig _config;
        public Scope Scope { get; set; }

        public MainWindow()
        {
            BassNetRegistration.CallBassNetRegistration();
            //RunSpotify();
            _config = new SpotifyLocalAPIConfig();
            _config.HostUrl = "http://127.0.0.1";
            _config.Port = 4381;
            _config.TimerInterval = 50;
            InitializeComponent();
            //CfidKey = GetCfid();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //using (WebClient wc = new WebClient())
            //{
            //    wc.Headers.Add("Authorization",
            //        "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(ClientId + ":" + ClientSecret)));

            //    NameValueCollection col = new NameValueCollection
            //    {
            //        {"grant_type", "client_credentials"},
            //        {"scope", Scope.GetStringAttribute(" ")}
            //    };

            //    byte[] data;
            //    try
            //    {
            //        data = wc.UploadValues("https://accounts.spotify.com/api/token", "POST", col);
            //    }
            //    catch (WebException ex)
            //    {
            //        using (StreamReader reader = new StreamReader(ex.Response.GetResponseStream()))
            //        {
            //            data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            //        }
            //    }
            //    var token = JsonConvert.DeserializeObject<Token>(Encoding.UTF8.GetString(data));

            //    OauthKey = token.AccessToken;
            //}
            //SendPlayRequest("https://open.spotify.com/track/4myBMnNWZlgvVelYeTu55w", "");

            //var urlTrack = new List<string>();
            //urlTrack.Add("https://open.spotify.com/track/2TpxZ7JUBn3uw46aR7qd6V");
            //urlTrack.Add("https://open.spotify.com/track/4PjcfyZZVE10TFd9EKA72r");
            //urlTrack.Add("https://open.spotify.com/track/2tniUNfN0hmqavFuJ2NodO");

            //urlTrack.Add("https://p.scdn.co/mp3-preview/12b8cee72118f995f5494e1b34251e4ac997445e?cid=8897482848704f2a8f8d7c79726a70d4");
            //urlTrack.Add("https://p.scdn.co/mp3-preview/4a54d83c195d0bc17b1b23fc931d37fb363224d8?cid=8897482848704f2a8f8d7c79726a70d4");
            //urlTrack.Add("https://p.scdn.co/mp3-preview/fce49876156ffb50ecc873e0fc7e1714bc03f10b?cid=8897482848704f2a8f8d7c79726a70d4");

            //BassNetClass BassNet = new BassNetClass();

            //BassNet.StartBass();
            Un4seen.Bass.BassNet.Registration("denis.gromenko@vilmate.com", "2X9232426172922");
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                int stream1 = Bass.BASS_StreamCreateURL("https://p.scdn.co/mp3-preview/12b8cee72118f995f5494e1b34251e4ac997445e?cid=8897482848704f2a8f8d7c79726a70d4", 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);
                int stream2 = Bass.BASS_StreamCreateURL("https://p.scdn.co/mp3-preview/4a54d83c195d0bc17b1b23fc931d37fb363224d8?cid=8897482848704f2a8f8d7c79726a70d4", 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);
                int stream3 = Bass.BASS_StreamCreateURL("https://p.scdn.co/mp3-preview/fce49876156ffb50ecc873e0fc7e1714bc03f10b?cid=8897482848704f2a8f8d7c79726a70d4", 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);
                // create a stream channel from a file
                //if (stream1 != 0)
                //{

                //Bass.BASS_ChannelSetPosition(stream2, Bass.BASS_ChannelSeconds2Bytes(stream2, 10.20), BASSMode.BASS_POS_BYTES);
                //Bass.BASS_ChannelSlideAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, 1, 5000);
                //Bass.BASS_ChannelPlay(stream1, false);
                Bass.BASS_ChannelPlay(stream2, false);
                //Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, 1F);

                //}
                //else
                //{
                // error creating the stream
                //Console.WriteLine("Stream error: {0}", Bass.BASS_ErrorGetCode());
                //}

                // wait for a key
                //Console.WriteLine("Press any key to exit");
                //Console.ReadKey(false);

                // free the stream
                //Bass.BASS_StreamFree(stream1);
                Bass.BASS_StreamFree(stream2);
                // free BASS
                Bass.BASS_Free();
            }


        }




        //internal async Task SendPlayRequest(string url, string context = "")
        //{
        //    // TODO: instead of having an empty context, one way to fix the bug with the playback time beyond the length of a song would be to provide a 1-song context, and it would be fixed.
        //    await QueryAsync($"remote/play.json?uri={url}&context={context}", true, true, -1).ConfigureAwait(false);
        //}

        //internal async Task<string> QueryAsync(string request, bool oauth, bool cfid, int wait)
        //{
        //    string parameters = "?&ref=&cors=&_=" + GetTimestamp();
        //    if (request.Contains("?"))
        //    {
        //        parameters = parameters.Substring(1);
        //    }

        //    if (oauth)
        //    {
        //        parameters += "&oauth=" + OauthKey;
        //    }
        //    if (cfid)
        //    {
        //        parameters += "&csrf=" + CfidKey;
        //    }

        //    if (wait != -1)
        //    {
        //        parameters += "&returnafter=" + wait;
        //        parameters += "&returnon=login%2Clogout%2Cplay%2Cpause%2Cerror%2Cap";
        //    }

        //    string address = $"{_config.HostUrl}:{_config.Port}/{request}{parameters}";
        //    string response = "";
        //    try
        //    {
        //        using (var wc = new ExtendedWebClient())
        //        {
        //            if (SpotifyLocalAPI.IsSpotifyRunning())
        //                response = "[ " + await wc.DownloadStringTaskAsync(new Uri(address)).ConfigureAwait(false) + " ]";
        //        }
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }

        //    return response;
        //}
        //public static void RunSpotify()
        //{
        //    if (!IsSpotifyRunning() && File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"spotify\spotify.exe")))
        //        Process.Start(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"spotify\spotify.exe"));
        //}
        //public static Boolean IsSpotifyRunning()
        //{
        //    return Process.GetProcessesByName("spotify").Length >= 1;
        //}
        //internal int GetTimestamp()
        //{
        //    return Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds);
        //}

        //internal string GetCfid()
        //{
        //    string response = Query("simplecsrf/token.json", false, false, -1);
        //    response = response.Replace(@"\", "");
        //    List<Cfid> cfidList = (List<Cfid>)JsonConvert.DeserializeObject(response, typeof(List<Cfid>));
        //    if (cfidList == null)
        //        return "";
        //    if (cfidList.Count != 1)
        //        throw new Exception("CFID could not be loaded");
        //    return cfidList[0].Error == null ? cfidList[0].Token : "";
        //}
        //internal string Query(string request, bool oauth, bool cfid, int wait)
        //{
        //    string parameters = "?&ref=&cors=&_=" + GetTimestamp();
        //    if (request.Contains("?"))
        //    {
        //        parameters = parameters.Substring(1);
        //    }

        //    if (oauth)
        //    {
        //        parameters += "&oauth=" + OauthKey;
        //    }
        //    if (cfid)
        //    {
        //        parameters += "&csrf=" + CfidKey;
        //    }

        //    if (wait != -1)
        //    {
        //        parameters += "&returnafter=" + wait;
        //        parameters += "&returnon=login%2Clogout%2Cplay%2Cpause%2Cerror%2Cap";
        //    }

        //    string address = $"{_config.HostUrl}:{_config.Port}/{request}{parameters}";
        //    string response = "";
        //    try
        //    {
        //        using (var wc = new ExtendedWebClient())
        //        {
        //            if (SpotifyLocalAPI.IsSpotifyRunning())
        //            {
        //                response = "[ " + wc.DownloadString(address) + " ]";
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }

        //    return response;
        //}
    }
}
