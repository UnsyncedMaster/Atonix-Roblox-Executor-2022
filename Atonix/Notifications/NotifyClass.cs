using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atonix.Notifications
{
    public static class NotifyClass
    {
        public static void Alert(string title, string description, Notification.EnumType type)
        {
            Notification NotifyForm = new Notification();
            NotifyForm.showNotifications(title, description, type);
        }
    }
}
