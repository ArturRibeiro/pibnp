using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Commands
{
    public class DesativarMembroCommand : BaseMembroCommand
    {
        public DesativarMembroCommand(Guid id)
        {
            this.Id = id;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
