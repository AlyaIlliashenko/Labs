using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public class PhoneSpeaker : IPlayback
    {
        private IOutput __output;
        public PhoneSpeaker(IOutput output)
        {
            __output = output;
        }
        public void Play()
        {
            __output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
