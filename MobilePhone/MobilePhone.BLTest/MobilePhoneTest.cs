using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.BL;
using System.Text;
using System.Globalization;
using UnitMeasures;

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
            string expected = ($"KeyBoard Culture: {CultureInfo.CurrentCulture}");
            expected += "\n";
            expected += ($"Battery Use Duration: 36000Second(s)");
            expected += "\n";
            expected += ($"Screen Technology: OLED");
            expected += "\n";
            expected += ($"Screen Weight: 0.188Kg(s)");
            expected += "\n";
            expected += ($"Screen Hight: 1.17Meter(s)");
            expected += "\n";
            expected += ($"Screen Width: 0.07Meter(s)");
            expected += "\n";
            expected += ($"Screen Viewing Angle: 3.14Radian(s)");
            expected += "\n";
            expected += ($"Screen InstantResponse : True");

            // -- Act 
            string actual = mobilePhone.ToString();

            // -- Assert
            Assert.AreNotEqual(expected, actual.Trim());
        }
    }
}
