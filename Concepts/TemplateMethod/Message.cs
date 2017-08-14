namespace Concepts.TemplateMethod
{
    public class Message
    {
        public NotificationSender Sender { get; set; }

        public void Send()
        {
            Sender.Notify();
        }
    }
}
