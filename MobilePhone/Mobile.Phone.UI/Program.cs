using MobilePhone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.UI
{
    class Program
    {
        static void Main()
        {
            /// Lab1
            var mobilePhone = new SimCorpMobile();
            Console.WriteLine(mobilePhone);

            /// Lab2
            IOutput consoleOutput = new ConsoleOutput();
            consoleOutput.WriteLine("Select playback component(select index):");
            consoleOutput.WriteLine($"{(int)PlaybackDeviceType.PhoneHeadset} - {PlaybackDeviceType.PhoneHeadset.ToString()}");
            consoleOutput.WriteLine($"{(int)PlaybackDeviceType.PhoneSpeaker} - {PlaybackDeviceType.PhoneSpeaker.ToString()}");
            var playableDeviceTypeString = Console.ReadLine();
            try
            {
                var playableDeviceType = CallTryParse(playableDeviceTypeString);
                var playbackDevice = PlaybackDeviceFactory.CreatePlaybackDevice((PlaybackDeviceType)playableDeviceType, consoleOutput);
                /// Method Injection
                /// Inject the dependency into a single method and generally for the use of that method
                /// It could be useful, where the whole class does not need the dependency, only one method having that dependency
                /// This is the way is rarely used, but it is what we need in this case 
                mobilePhone.Play(playbackDevice, consoleOutput);
            }
            catch (ArgumentException ex)
            {
                consoleOutput.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static int CallTryParse(string stringToConvert)
        {
            int convertedNumber;
            var success = Int32.TryParse(stringToConvert, out convertedNumber);
            if (!success)
            {
                throw new ArgumentException("Unexpected index!");
            }
            return convertedNumber;
        }
    }
}
