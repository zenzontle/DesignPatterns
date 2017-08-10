using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemOperator systemOperator = new SystemOperator();
            systemOperator.CellPhone = "123456789";
            systemOperator.Email = "test@operator.com";
            systemOperator.Name = "Super Operator";
            systemOperator.Pager = "951753";

            Message message = new Message();

            message.Sender = new SmsNotificationSender(systemOperator);
            message.Send();

            message.Sender = new MailNotificationSender(systemOperator);
            message.Send();

            Console.ReadKey();
        }
    }
}
