using System.Collections.Generic;
using PibNP.Domain.Core.Events;

namespace PibNP.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications();
    }
}