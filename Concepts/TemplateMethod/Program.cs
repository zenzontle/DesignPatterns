using System;

namespace Concepts.TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            SystemOperator systemOperator = new SystemOperator
            {
                CellPhone = "123456789",
                Email = "test@operator.com",
                Name = "Super Operator",
                Pager = "951753"
            };

            Message message = new Message {Sender = new SmsNotificationSender(systemOperator)};

            message.Send();

            message.Sender = new MailNotificationSender(systemOperator);
            message.Send();

            Console.ReadKey();
        }
    }
}
