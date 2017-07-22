using Pib.NP.Domain.Core.Events;
using Pib.NP.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Events
{
    public class MembroRegistradoEvent : BaseMembroEvent
    {
        public MembroRegistradoEvent(Guid id, string nome, string foto, Email email, DateTime? aniversario, DateTime? batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil estadoCivil, Cpf cpf, Rg rg)
        {
            Id = id;
            Nome = nome;
            Foto = foto;
            Email = email;
            Aniversario = aniversario;
            Batismo = batismo;
            Residencial = residencial;
            Celular = celular;
            Comercial = comercial;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Cpf = cpf;
            Rg = rg;
        }
    }
}
