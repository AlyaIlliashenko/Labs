using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public abstract class MobilePhone
    {
        public abstract KeyBoard KeyBoard { get;  }
        public abstract Battery Battery { get;  }
        public abstract ScreenBase Screen { get; }

        public override string ToString()
        {
            var showBuilder = new StringBuilder();
            showBuilder.AppendLine(KeyBoard.ToString());
            showBuilder.AppendLine(Battery.ToString());
            showBuilder.AppendLine(Screen.ToString());
            return showBuilder.ToString();
        }

        public void Play(IPlayback playbackDevice,IOutput output)
        {
            output.WriteLine("Play sound in Mobile");
            playbackDevice.Play();
        }
    }
}
