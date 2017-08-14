using System;

namespace Concepts.TemplateMethod
{
    public class MailNotificationSender : NotificationSender
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
            Console.WriteLine("Email message:{0} was sent to {1}", GetNotificationMessageText(), SystemOperator.Email);
        }
    }
}
