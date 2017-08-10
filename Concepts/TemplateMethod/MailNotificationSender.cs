using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class MailNotificationSender : NotificationSender
    {
        public MailNotificationSender(SystemOperator systemOperator)
            : base(systemOperator)
        {
        }

        protected override string GetNotificationMessageText()
        {
            return "Hello, mail!";
        }

        public override void Notify()
        {
            Console.WriteLine("Email message:{0} was sent to {1}", GetNotificationMessageText(), _systemOperator.Email);
        }
    }
}
