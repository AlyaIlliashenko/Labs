using System;
using UnitMeasures;

namespace MobilePhone.BL
{
    public class Battery
    {
        public Time BatteryUseDuration { get; set; }

        public override string ToString()
        {
            return ($"Battery Use Duration: {BatteryUseDuration.ToString()}");
        }
    }

}