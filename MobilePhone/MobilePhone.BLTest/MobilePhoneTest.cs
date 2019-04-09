using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.BL;
using MobilePhone.Common;
using MessageFormatting.UI;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace MobilePhone.BLTest
{
    [TestClass]
    public class SimCorpMobilePhoneTest
    {

        [TestMethod]
        public void MobilePhoneToStringTest()
        {
            // -- Arrange
            var mobilePhone = new SimCorpMobile();
            var showBuilder = new StringBuilder();
            showBuilder.AppendLine($"KeyBoard Culture: {CultureInfo.CurrentCulture}");
            showBuilder.AppendLine($"Battery Use Duration: 10:30:00");
            showBuilder.AppendLine($"Screen Technology: OLED");
            showBuilder.AppendLine($"Screen Weight: 0,188 Kilograms");
            showBuilder.AppendLine($"Screen Hight: 0,17 Metres");
            showBuilder.AppendLine($"Screen Width: 0,07 Metres");
            showBuilder.AppendLine($"Screen InstantResponse: True");
            string expected = showBuilder.ToString().Trim();

            // -- Act 
            string actual = mobilePhone.ToString();

            // -- Assert
            Assert.AreEqual(expected, actual.Trim());
        }
        [TestMethod]
        public void PhoneHeadsetPlayTest()
        {
            // -- Arrange
            var output = new FakeOutput();
            var phoneHeadset = new PhoneHeadset(output);
            var expected = "fake PhoneHeadset sound";

            // -- Act 
            phoneHeadset.Play();
            var actual = output.FakeOutputString;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMessageFormatTest()
        {
            // -- Arrange
            string message = "simcorp test";
            MessageFormat format = MessageFormat.Uppercase;
            var expected = "SIMCORP TEST";

            // -- Act
            var actual = FormMessageFormating.SetMessageFormat(message, format);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RaiseEventTest()
        {
            // -- Arrange
            var smsStorage = new SMSStorage();
            var message = "SimCorp";
            string actual = null;

            // -- Act
            smsStorage.SMSProviderService.SMSRecieved += (m) => actual = m;
            smsStorage.SMSProviderService.OnSMSRecieved(message);

            // -- Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual("SimCorp", actual);
        }

        [TestMethod]
        public void MakeQueryUserTest()
        {
            // -- Arrange
            var messageList = new List<MobilePhone.BL.Message>
            {
                new MobilePhone.BL.Message { User = "2222", Text = "testText1", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "1111", Text = "testText2", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "2222", Text = "testText3", ReceivingTime = DateTime.Now },
            };
            var form = new FormMessageFormating();
            var receiversFilter = "2222";
            var textFilter = "";
            var filteringLogic = "";
            var expected = "testText1testText3";

            // -- Act
            var query = form.MakeQuery(messageList, receiversFilter, textFilter, filteringLogic);
            string actual = "";
            foreach (var m in query)
            {
                actual += $"{m.Text}";
            }

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeQueryTextTest()
        {
            // -- Arrange
            var messageList = new List<MobilePhone.BL.Message>
            {
                new MobilePhone.BL.Message { User = "2222", Text = "testText1", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "1111", Text = "testText22", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "2222", Text = "testText23", ReceivingTime = DateTime.Now },
            };
            var form = new FormMessageFormating();
            var receiversFilter = "2222";
            var textFilter = "text2";
            var filteringLogic = "";
            var expected = "testText23";

            // -- Act
            var query = form.MakeQuery(messageList, receiversFilter, textFilter, filteringLogic);
            string actual = "";
            foreach (var m in query)
            {
                actual += $"{m.Text}";
            }

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MakeQueryCombTest()
        {
            // -- Arrange
            var messageList = new List<MobilePhone.BL.Message>
            {
                new MobilePhone.BL.Message { User = "2222", Text = "testText1", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "1111", Text = "testText22", ReceivingTime = DateTime.Now },
                new MobilePhone.BL.Message { User = "2222", Text = "testText23", ReceivingTime = DateTime.Now },
            };
            var form = new FormMessageFormating();
            var receiversFilter = "2222";
            var textFilter = "text2".ToUpper();
            var filteringLogic = "OR";
            var expected = "testText1testText22testText23";

            // -- Act
            var query = form.MakeQuery(messageList, receiversFilter, textFilter, filteringLogic);
            string actual = "";
            foreach (var m in query)
            {
                actual += $"{m.Text}";
            }

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SMSStorageTest()
        {
            // -- Arrange
            var smsStorage = new SMSStorage();
            var meessage = "SimCorp";
            var expected = 1;

            // -- Act
            smsStorage.ReceiveMessage(meessage);
            var actual = smsStorage.MessageList.Count;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
