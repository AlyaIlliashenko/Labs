using System;

namespace MobilePhone.BL
{
    public class Battery
    {
        public TimeSpan BatteryUseDuration { get; set; }

        public override string ToString() => ($"Battery Use Duration: {BatteryUseDuration.ToString()}");
    }

}