using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class SmsNotificationSender : NotificationSender
    {
        public SmsNotificationSender(SystemOperator systemOperator)
            : base(systemOperator)
        {
        }

        protected override string GetNotificationMessageText()
        {
            return "Hello, sms!";
        }

        public override void Notify()
        {
            Console.WriteLine("SMS message:{0} was sent to {1}", GetNotificationMessageText(), _systemOperator.CellPhone);
        }
    }
}
