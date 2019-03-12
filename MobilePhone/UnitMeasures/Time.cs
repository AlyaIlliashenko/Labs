using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMeasures
{
    public class Time
    {
        private readonly int __second;

        public Time(int second)
        {
            __second = second;
        }

        public override string ToString()
        {
            return ($"{__second.ToString()}Second(s)");
        }
    }
}
