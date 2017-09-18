using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void Play(List<string> albumTracksUrls)
        {
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                int stream1 = Bass.BASS_StreamCreateURL(albumTracksUrls[0], 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);
                int stream2 = Bass.BASS_StreamCreateURL(albumTracksUrls[1], 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);
                int stream3 = Bass.BASS_StreamCreateURL(albumTracksUrls[2], 0, BASSFlag.BASS_SAMPLE_MONO, null, IntPtr.Zero);

                //Bass.BASS_ChannelSetPosition(stream2, Bass.BASS_ChannelSeconds2Bytes(stream2, 10.20), BASSMode.BASS_POS_BYTES);
                Bass.BASS_ChannelSlideAttribute(stream1, BASSAttribute.BASS_ATTRIB_VOL, 0, 0);
                Bass.BASS_ChannelPlay(stream1, false);
                VolumeUpSlow(stream1);
                Bass.BASS_ChannelSlideAttribute(stream1, BASSAttribute.BASS_ATTRIB_VOL, 0, 3000);//volume down
                Thread.Sleep(2500);
                Bass.BASS_StreamFree(stream1);
                Bass.BASS_ChannelSlideAttribute(stream2, BASSAttribute.BASS_ATTRIB_VOL, 0, 0);
                Bass.BASS_ChannelPlay(stream2, false);
                VolumeUpSlow(stream2);
                Bass.BASS_ChannelSlideAttribute(stream2, BASSAttribute.BASS_ATTRIB_VOL, 0, 3000);//volume down
                Bass.BASS_ChannelSlideAttribute(stream3, BASSAttribute.BASS_ATTRIB_VOL, 0, 0);
                Bass.BASS_ChannelPlay(stream3, false);
                VolumeUpSlow(stream3);
                Bass.BASS_StreamFree(stream2);
                Thread.Sleep(5000);
                Bass.BASS_StreamFree(stream3);
                // free BASS
                Bass.BASS_Free();
            }
        }

        private static void VolumeUpSlow(int stream)
        {
            var stream2VolumeValue = 0F;
            for (int i = 0; 100 > i; i++)
            {
                stream2VolumeValue = stream2VolumeValue + 0.01F;
                Thread.Sleep(30);
                Bass.BASS_ChannelSlideAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, stream2VolumeValue, 0);
            }
        }
        private static void VolumeDownSlow(int stream)
        {
            var stream2VolumeValue = 1F;
            for (int i = 0; 100 > i; i++)
            {
                stream2VolumeValue = stream2VolumeValue - 0.01F;
                Thread.Sleep(30);
                Bass.BASS_ChannelSlideAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, stream2VolumeValue, 0);
            }
        }
    }
}
