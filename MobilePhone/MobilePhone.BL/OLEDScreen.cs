using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitMeasures;

namespace MobilePhone.BL
{
    public class OLEDScreen : ScreenBase
    {
        private readonly bool __instantResponse;
        public OLEDScreen()
        {
            Technology = "OLED";
            ViewingAngle = new Angle(3.14);
            __instantResponse = true;
        }
        public override string ToString()
        {
            var showBuilder = new StringBuilder();
            var baseString = base.ToString();
            showBuilder.AppendLine(baseString + $"Screen InstantResponse : {__instantResponse.ToString()}");
            return showBuilder.ToString();
        }
    }
}
