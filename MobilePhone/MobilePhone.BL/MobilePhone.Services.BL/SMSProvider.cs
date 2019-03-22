using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public class SMSProvider
    {
        private static readonly SMSProvider _Instance = new SMSProvider();
        public delegate void SMSRecievedDelegate(string meessage);
        private SMSProvider() { }

        public static SMSProvider GetInstance()
        {
            return _Instance;
        }

        public event SMSRecievedDelegate SMSRecieved;

        public void OnSMSRecieved(string meessage)
        {
            var SMSRecievedeDelegate = SMSRecieved as SMSRecievedDelegate;
            if (SMSRecievedeDelegate != null)
            {
                SMSRecievedeDelegate(meessage);
            }
        }
    }
}
