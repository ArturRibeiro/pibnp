﻿using System;
using Pib.NP.Domain.Core.Events;

namespace Pib.NP.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        #region Propriedades
        public Guid DomainNotificationId
        {
            get;
            private set;
        }

        public string Key
        {
            get;
            private set;
        }

        public string Value
        {
            get;
            private set;
        }

        public int Version
        {
            get;
            private set;
        } 
        #endregion

        public DomainNotification(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }
    }
}