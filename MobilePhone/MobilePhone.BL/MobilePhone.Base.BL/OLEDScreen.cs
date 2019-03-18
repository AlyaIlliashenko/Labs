using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public class OLEDScreen : ScreenBase
    {
        private readonly bool __instantResponse;
        public OLEDScreen()
        {
            Technology = "OLED";
            __instantResponse = true;
        }
        public override string ToString()
        {
            var showBuilder = new StringBuilder();
            var baseString = base.ToString();
            showBuilder.AppendLine(baseString + $"Screen InstantResponse: {__instantResponse.ToString()}");
            return showBuilder.ToString();
        }
    }
}
