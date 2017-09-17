using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace MixingApp.Services
{
    public class BassNetService
    {
        public void CallBassNetRegistration()
        {
            BassNet.Registration("denis.gromenko@vilmate.com", "2X9232426172922");
        }

        public void Play()
        {
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
    }
}
