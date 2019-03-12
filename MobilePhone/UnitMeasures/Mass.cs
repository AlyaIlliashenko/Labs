using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitMeasures
{
    public class Mass
    {
       private readonly double __kg;
       public Mass(double kg)
        {
            __kg = kg;
        }

        public override string ToString()
        {
            return ($"{__kg.ToString()}Kg(s)");
        }
    }
}
