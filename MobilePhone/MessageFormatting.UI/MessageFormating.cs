using MobilePhone.BL;
using MobilePhone.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageFormatting.UI
{
    public enum MessageFormat
    {
        None = 0,
        DateAndTime = 1,
        Uppercase = 2
    }

    public partial class FormMessageFormating : Form
    {

        private delegate void ShowMessageInfoDelegate(string message);

        public FormMessageFormating()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonStart.Enabled = true;

            backgroundWorkerMessageReciecer.CancelAsync();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonCancel.Enabled = true;

            backgroundWorkerMessageReciecer.RunWorkerAsync();
        }

        private void ShowMessageInfo(string message)
        {
            if (richTextBoxMessageInfo.InvokeRequired == true)
            {
               var del = new ShowMessageInfoDelegate(ShowMessageInfo);
                this.Invoke(del, new object[] { message });
            }
            else
            {
                var winformOutput = new WinFormOutput(richTextBoxMessageInfo);
                var format = CreateFormat();
                winformOutput.WriteLine(SetMessageFormat($"{message} SMS recieved!", format));
            }
        }

        private void backgroundWorkerMessageReciecer_DoWork(object sender, DoWorkEventArgs e)
        {
            var mobilePhone = new SimCorpMobile();
            var meessage = "SimCorp: ";
            mobilePhone.SMSProviderService.SMSRecieved += (m) => ShowMessageInfo(meessage);
            do
            {
                mobilePhone.SMSProviderService.OnSMSRecieved(meessage);
                Thread.Sleep(3000);
            }
            while (!backgroundWorkerMessageReciecer.CancellationPending == true);
            e.Cancel = true;
            var winformOutput = new WinFormOutput(richTextBoxMessageInfo);
        }

        private MessageFormat CreateFormat()
        {
            var format = MessageFormat.None;
            var index = comboBoxSelectFormatting.SelectedIndex;
                switch (index)
                {
                    case 1:
                        format = MessageFormat.DateAndTime;
                        break;
                    case 2:
                        format = MessageFormat.Uppercase;
                        break;
                }
            return format;
        }

        public static string SetMessageFormat(string message, MessageFormat format)
        {
            string formatedMessage;
            switch (format)
            {
                case MessageFormat.DateAndTime:
                    formatedMessage = $"[{DateTime.Now}] {message}";
                    break;
                case MessageFormat.Uppercase:
                    formatedMessage = $"{message}".ToUpper();
                    break;
                default:
                    formatedMessage = message;
                    break;
            }
            return formatedMessage;
        }
    }
}
