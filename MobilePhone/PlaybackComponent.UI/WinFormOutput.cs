using MobilePhone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaybackComponent.UI
{
    class WinFormOutput : IOutput
    {
        private readonly TextBox __textBox;
        public WinFormOutput(TextBox textBox)
        {
            __textBox = textBox;
        }
        public void WriteLine(string text)
        {
            __textBox.AppendText(text + "\r\n");
        }
    }
}
