using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMeasures
{
    public class Length
    {
        private readonly double __meter;
        public Length(double meter)
        {
            __meter = meter;
        }

        public override string ToString()
        {
            return ($"{__meter.ToString()}Meter(s)");
        }
    }
}
