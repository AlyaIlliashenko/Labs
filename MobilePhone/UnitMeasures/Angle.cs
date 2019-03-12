using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMeasures
{
    public class Angle
    {
        private readonly double __radian;

        public Angle(double radian)
        {
            __radian = radian;
        }

        public override string ToString()
        {
            return ($"{__radian.ToString()}Radian(s)");
        }
    }
}
