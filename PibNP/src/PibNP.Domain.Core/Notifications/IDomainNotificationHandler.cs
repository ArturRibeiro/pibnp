using System.Collections.Generic;
using Pib.NP.Domain.Core.Events;

namespace Pib.NP.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications();
    }
}