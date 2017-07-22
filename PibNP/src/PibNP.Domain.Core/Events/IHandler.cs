using System;

namespace Pib.NP.Domain.Core.Events
{
    //in T => Contra variante
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}