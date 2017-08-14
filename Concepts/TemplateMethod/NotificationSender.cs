namespace Concepts.TemplateMethod
{
    public abstract class NotificationSender
    {
        protected SystemOperator SystemOperator;

        protected NotificationSender(SystemOperator systemOperator)
        {
            SystemOperator = systemOperator;
        }

        protected abstract string GetNotificationMessageText();

        public abstract void Notify();
    }
}
