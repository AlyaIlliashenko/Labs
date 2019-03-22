using MobilePhone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhone.Common
{
    public class WinFormOutput : IOutput
    {
        private readonly RichTextBox __richTextBox;
        public WinFormOutput(RichTextBox richTextBox)
        {
            __richTextBox = richTextBox;
        }
        public void WriteLine(string text)
        {
            __richTextBox.AppendText(text + "\r\n");
        }

    }
}
