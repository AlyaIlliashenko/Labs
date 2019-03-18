using MobilePhone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BLTest
{
    class FakeOutput : IOutput
    {
        public string FakeOutputString { get; set; }
        public void WriteLine(string text)
        {
            FakeOutputString = "fake " + text;
        }
    }
}
