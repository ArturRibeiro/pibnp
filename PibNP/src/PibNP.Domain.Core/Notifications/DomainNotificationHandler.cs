using System.Collections.Generic;
using System.Linq;
using Pib.NP.Domain.Core.Events;
using System;

namespace Pib.NP.Domain.Core.Notifications
{
    public class DomainNotificationHandler : IDomainNotificationHandler<DomainNotification>, IDisposable
    {
        private List<DomainNotification> notifications;

        public DomainNotificationHandler()
        {
            notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification message)
        {
            notifications.Add(message);
        }

        public List<DomainNotification> GetNotifications()
        {
            return notifications;
        }

        public bool HasNotifications()
        {
            return GetNotifications().Any();
        }

        public void Dispose()
        {
            notifications = new List<DomainNotification>();
        }
    }
}