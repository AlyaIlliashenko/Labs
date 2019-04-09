using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BL
{
    public class SMSStorage
    {
        private List<Message> __messageList;
        public List<string> Receievers = new List<string> { "+38 999 222 33 11", "+38 888 333 55 11", "+38 777 111 22 11" };

        public SMSStorage()
        {
            __messageList = new List<Message>();
        }

        public SMSProvider SMSProviderService
        {
            get { return SMSProvider.GetInstance(); }
        }

        public void ReceiveMessage(string fomatedMessage)
        {
            SMSProviderService.OnSMSRecieved(fomatedMessage);
            AddMessage(fomatedMessage);
        }

        public void AddMessage(string fomatedMessage)
        {
            var rnd = new Random();
            var index = rnd.Next(Receievers.Count);
            var message = new Message
            {
                User = Receievers[index],
                Text = fomatedMessage,
                ReceivingTime = DateTime.Now

            };
            __messageList.Add(message);
        }
        public List<Message> MessageList => __messageList;

    } 
}
