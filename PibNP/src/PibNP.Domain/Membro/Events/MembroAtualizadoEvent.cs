using Pib.NP.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Events
{
    public class MembroAtualizadoEvent : BaseMembroEvent
    {
        public MembroAtualizadoEvent(Guid id, string nome, string foto, string email, DateTime aniversario, DateTime batismo, string residencial, string celular, string comercial, int sexo, int estadoCivil, string cpf, string rg)
        {
            this.Id = id;
            this.Nome = nome;
            this.Foto = foto;
            this.Email = new Email(email);
            this.Aniversario = aniversario;
            this.Batismo = batismo;
            this.Residencial = new Telefone(residencial);
            this.Celular = new Telefone(celular);
            this.Comercial = new Telefone(comercial);
            this.Sexo = (Sexo)sexo;
            this.EstadoCivil = (EstadoCivil)estadoCivil;
            this.Cpf = new Cpf(cpf);
            this.Rg = new Rg(rg);
        }
    }
}
