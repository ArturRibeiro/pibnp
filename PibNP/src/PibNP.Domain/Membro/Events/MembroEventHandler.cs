using Pib.NP.Domain.Core.Events;
using System;

namespace Pib.NP.Domain.Membro.Events
{
    public class MembroEventHandler :
        IHandler<MembroRegistradoEvent>,
        IHandler<MembroAtualizadoEvent>,
        IHandler<MembroDesativadoEvent>
    {
        public void Handle(MembroDesativadoEvent message)
        {
            throw new NotImplementedException();
        }

        public void Handle(MembroAtualizadoEvent message)
        {
            throw new NotImplementedException();
        }

        public void Handle(MembroRegistradoEvent message)
        {
            throw new NotImplementedException();
        }
    }
}
