using Pib.NP.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
