using Pib.NP.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Commands
{
    public abstract class BaseMembroCommand : Command
    {
        #region Properties

        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string Foto { get; protected set; }

        public Situacao Situacao { get; protected set; }

        public string Email { get; protected set; }

        public DateTime? Aniversario { get; protected set; }

        public DateTime? Batismo { get; protected set; }

        public bool Batizado { get; protected set; }

        public string Residencial { get; protected set; }

        public string Celular { get; protected set; }

        public string Comercial { get; protected set; }

        public int Sexo { get; protected set; }

        public int EstadoCivil { get; protected set; }

        public string Cpf { get; protected set; }

        public string Rg { get; protected set; }

        //public Endereco Endereco { get; private set; }

        #endregion
    }
}
