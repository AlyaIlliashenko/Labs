using MobilePhone.BL;
using MobilePhone.UI;
using MobilePhone.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaybackComponent.UI
{
    public partial class formPlaybackComponent : Form
    {
        public formPlaybackComponent()
        {
            InitializeComponent();
        }

        private void MobilePhone_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectPlaybackComp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplyPlaybackComp_Click(object sender, EventArgs e)
        {
            richTextBoxPlaybackCompInfo.Clear();
            string selectedItem = comboBoxSelectPlaybackComp.Text;
            var playableDeviceType = PlaybackDeviceType.None;
            if (selectedItem == "PhoneHeadset")
            {
                playableDeviceType = PlaybackDeviceType.PhoneHeadset;
            }
            else if (selectedItem == "PhoneSpeaker")
            {
                playableDeviceType = PlaybackDeviceType.PhoneSpeaker;
            }

            IOutput winformOutput = new WinFormOutput(richTextBoxPlaybackCompInfo);
            if (playableDeviceType != PlaybackDeviceType.None)
            {
                var mobilePhone = new SimCorpMobile();
                var playbackDevice = PlaybackDeviceFactory.CreatePlaybackDevice(playableDeviceType, winformOutput);
                mobilePhone.Play(playbackDevice, winformOutput);
            }
            else
            {
                winformOutput.WriteLine("Select PlaybackDeviceType!");
            }
        }
    }
}
