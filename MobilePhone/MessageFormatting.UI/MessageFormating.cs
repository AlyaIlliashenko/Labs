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
        private delegate MessageFormat SetMessageFormatDelegate();
        private List<string> providers = new List<string> { "Simcorp", "Vodafone", "KiyvStar" };
        private SMSStorage smsStorage = new SMSStorage();

        public FormMessageFormating()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            var smsStorage = new SMSStorage();
            var receievers = smsStorage.Receievers;
            var receieversCount = receievers.Count;
            System.Object[] ItemObject = new System.Object[receieversCount + 1];
            for (int i = 0; i < receieversCount; i++)
            {
                ;
                ItemObject[i] = receievers[i];
            }
            ItemObject[receieversCount] = "";
            comboBoxUsers.Items.AddRange(ItemObject);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonStart.Enabled = true;
            buttonShow.Enabled = true;

            backgroundWorkerMessageReciecer.CancelAsync();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonCancel.Enabled = true;
            buttonShow.Enabled = false;

            backgroundWorkerMessageReciecer.RunWorkerAsync();
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            ShowReceivedInfo();
            buttonStart.Enabled = true;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReceivedInfo();
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            ShowReceivedInfo();
        }

        private void comboBoxFilteringLogic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReceivedInfo();
        }

        private void backgroundWorkerMessageReciecer_DoWork(object sender, DoWorkEventArgs e)
        {
            var rnd = new Random();
            var message = providers[1];
            var format = MessageFormat.None;
            var fomatedMessage = "";
            smsStorage.SMSProviderService.SMSRecieved += (m) => ShowMessageInfo(m);
            do
            {
                message = providers[rnd.Next(providers.Count)];
                format = CreateFormat();
                fomatedMessage = SetMessageFormat($"{message} SMS recieved!", format);

                smsStorage.ReceiveMessage(fomatedMessage);
                Thread.Sleep(1000);
            }
            while (!backgroundWorkerMessageReciecer.CancellationPending == true);

            e.Cancel = true;
            var winformOutput = new WinFormOutput(richTextBoxMessageInfo);
        }

        private void ShowMessageInfo(string textMessage)
        {
            if (richTextBoxMessageInfo.InvokeRequired == true)
            {
                var del = new ShowMessageInfoDelegate(ShowMessageInfo);
                this.Invoke(del, new object[] { textMessage });
            }
            else
            {
                var winformOutput = new WinFormOutput(richTextBoxMessageInfo);
                winformOutput.WriteLine(textMessage);
            }
        }

        private MessageFormat CreateFormat()
        {
            var format = MessageFormat.None;
            if (comboBoxSelectFormatting.InvokeRequired == true)
            {
                var del = new SetMessageFormatDelegate(CreateFormat);
                format = (MessageFormat)this.Invoke(del);
            }
            else
            {
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

        private void ShowReceivedInfo()
        {
            var receiversFilter = comboBoxUsers.SelectedItem;
            var textFilter = textBoxText.Text;
            var filteringLogic = comboBoxFilteringLogic.SelectedItem?.ToString();
            var messageList = smsStorage.MessageList;

            IEnumerable<MobilePhone.BL.Message> query = MakeQuery(messageList, receiversFilter, textFilter, filteringLogic);

            listViewShow.Items.Clear();
            foreach (var message in query)
            {
                string[] row = { $"{message.User}", $"{message.Text}", message.ReceivingTime.ToShortDateString() };
                listViewShow.Items.Add(new ListViewItem(row));
            }
        }

        public IEnumerable<MobilePhone.BL.Message> MakeQuery(List<MobilePhone.BL.Message> messageList, object receiversFilter, string textFilter, string filteringLogic)
        {
            textFilter = textFilter.ToUpper();

            var query =
                     messageList.Where(m => (receiversFilter == null || (string)receiversFilter == "" || m.User == receiversFilter.ToString())
                     && (m.Text.ToUpper().Contains(textFilter)))
                    .Select(m => m);
            if (filteringLogic == "OR")
            {
                query =
                        messageList.Where(m => (receiversFilter == null || (string)receiversFilter == "" || m.User == receiversFilter.ToString())
                        || (m.Text.ToUpper().Contains(textFilter)))
                        .Select(m => m);
            }

            return query;
        }
    }
}
