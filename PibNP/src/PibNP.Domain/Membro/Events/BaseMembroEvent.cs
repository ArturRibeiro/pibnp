using Pib.NP.Domain.Core.Events;
using Pib.NP.Domain.Core.ValueObjects;
using System;

namespace Pib.NP.Domain.Membro.Events
{
    public abstract class BaseMembroEvent : Event
    {
        #region Properties

        public Guid Id { get; protected set; }

        public string Nome { get; protected set; }

        public string Foto { get; protected set; }

        public Situacao Situacao { get; protected set; }

        public Email Email { get; protected set; }

        public DateTime? Aniversario { get; protected set; }

        public DateTime? Batismo { get; protected set; }

        public bool Batizado { get; protected set; }

        public Telefone Residencial { get; protected set; }

        public Telefone Celular { get; protected set; }

        public Telefone Comercial { get; protected set; }

        public Sexo Sexo { get; protected set; }

        public EstadoCivil EstadoCivil { get; protected set; }

        public Cpf Cpf { get; protected set; }

        public Rg Rg { get; protected set; }

        //public Endereco Endereco { get; private set; }

        #endregion
    }
}
