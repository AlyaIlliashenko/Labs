using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public class PhoneHeadset : IPlayback
    {
        private IOutput __output;
        public PhoneHeadset(IOutput output)
        {
            __output = output;
        }
        public void Play()
        {
            __output.WriteLine($"{nameof(PhoneHeadset)} sound");
        }
    }
}
