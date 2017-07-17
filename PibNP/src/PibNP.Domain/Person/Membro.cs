using System;

namespace PibNP.Domain.Person
{
    public class Membro
    {
        #region Properties

        public string Nome { get; private set; }

        public Email Email { get; private set; }

        public DateTime Aniversario { get; private set; }

        public DateTime Batismo { get; private set; }

        public Telefone Residencial { get; private set; }

        public Telefone Celular { get; private set; }

        public Telefone Comercial { get; private set; }

        public Sexo Sexo { get; private set; }

        public EstadoCivil Status { get; private set; }

        public Cpf Cpf { get; private set; }

        public Rg Rg { get; private set; }

        public Endereco Endereco { get; private set; }

        #endregion

        #region Constructors

        public Membro()
        {

        }



        #endregion

        #region Factor

        public static class Factor
        {
            //public static Person Create(string name)
            //{
            //    return new Pessoa(name);
            //}
        }

        #endregion
    }
}
