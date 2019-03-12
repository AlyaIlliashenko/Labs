using MobilePhone.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Phone.UI
{
    class Program
    {
        static void Main()
        {
            var mobilePhone = new SimCorpMobile();

            Console.WriteLine(mobilePhone);
            Console.ReadKey();
        }
    }
}
