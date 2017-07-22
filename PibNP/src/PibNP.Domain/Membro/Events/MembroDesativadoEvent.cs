using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Events
{
    public class MembroDesativadoEvent : BaseMembroEvent
    {
        public MembroDesativadoEvent(Guid id)
        {
            this.Id = id;
        }
    }
}
