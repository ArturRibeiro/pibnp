using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Membro.Commands
{
    public class RegistrarMembroCommand : BaseMembroCommand
    {
        public RegistrarMembroCommand(string nome, string foto, string email, DateTime aniversario, DateTime batismo, string residencial, string celular, string comercial, int sexo, int estadoCivil, string cpf, string rg)
        {
            this.Nome = nome;
            this.Foto = foto;
            this.Email = email;
            this.Aniversario = aniversario;
            this.Batismo = batismo;
            this.Residencial = residencial;
            this.Celular = celular;
            this.Comercial = comercial;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
            this.Cpf = cpf;
            this.Rg = rg;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
