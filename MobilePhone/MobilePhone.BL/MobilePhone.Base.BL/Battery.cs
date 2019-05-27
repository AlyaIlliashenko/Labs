using NGenericDimensions;
using NGenericDimensions.Lengths.MetricSI;
using System;

namespace MobilePhone.BL
{
    public class Battery
    {
        public TimeSpan BatteryUseDuration { get; set; }
        private int __charge;
        public int Charge
        {
            get { return __charge; }
            set {
                if ( value >= 100 )
                {
                    __charge = 100;
                }
                else if (value < 0)
                {
                    __charge = 0;
                }
                else
                {
                    __charge = value;
                }
            }
        }
        public override string ToString() => ($"Battery Use Duration: {BatteryUseDuration.ToString()}");
    }

}