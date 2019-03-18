using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.BL;
using System.Text;
using System.Globalization;

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
            showBuilder.AppendLine($"Screen Weight: 0.188 Kilograms");
            showBuilder.AppendLine($"Screen Hight: 0.17 Metres");
            showBuilder.AppendLine($"Screen Width: 0.07 Metres");
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
    }
}
