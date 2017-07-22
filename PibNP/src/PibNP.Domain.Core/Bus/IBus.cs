using Pib.NP.Domain.Core.Commands;
using Pib.NP.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;

        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
