using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Message
    {
        public NotificationSender Sender { get; set; }

        public void Send()
        {
            Sender.Notify();
        }
    }
}
