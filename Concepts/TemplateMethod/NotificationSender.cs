using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class NotificationSender
    {
        protected SystemOperator _systemOperator;

        public NotificationSender(SystemOperator systemOperator)
        {
            _systemOperator = systemOperator;
        }

        protected abstract string GetNotificationMessageText();

        public abstract void Notify();
    }
}
