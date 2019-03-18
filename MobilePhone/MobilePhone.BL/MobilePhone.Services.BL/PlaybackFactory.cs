using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public enum PlaybackDeviceType
    {
        None = 0,
        PhoneHeadset = 1,
        PhoneSpeaker = 2
    }

    public class PlaybackDeviceFactory
    {
        public static IPlayback CreatePlaybackDevice(PlaybackDeviceType playableDeviceType,IOutput output)
        {
            output.WriteLine("Set playback to Mobile...");
            IPlayback playbackDevice = null;
            switch (playableDeviceType)
            {
                case PlaybackDeviceType.PhoneHeadset:
                    playbackDevice = new PhoneHeadset(output);
                    output.WriteLine($"{PlaybackDeviceType.PhoneHeadset.ToString()} is selected");
                    break;
                case PlaybackDeviceType.PhoneSpeaker:
                    playbackDevice = new PhoneSpeaker(output);
                    output.WriteLine($"{PlaybackDeviceType.PhoneSpeaker.ToString()} is selected");
                    break;
                default:
                    throw new ArgumentException("Unexpected index!");
            }
            return playbackDevice;
        }
    }
}
