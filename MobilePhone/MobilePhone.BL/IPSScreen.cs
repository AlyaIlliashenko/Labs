using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitMeasures;

namespace MobilePhone.BL
{
    public class IPSScreen : ScreenBase
    {
        private readonly bool __naturalColorReproduction;
        public IPSScreen()
        {
            Technology = "IPS";
            ViewingAngle = new Angle(3.12);
            __naturalColorReproduction = true;
        }
        public override string ToString()
        {
            var showBuilder = new StringBuilder();
            var baseString = base.ToString();
            showBuilder.AppendLine(base.ToString());
            showBuilder.AppendLine(baseString + $"Screen Natural Color Reproduction : {__naturalColorReproduction.ToString()}");
            return showBuilder.ToString();
        }
    }
}
