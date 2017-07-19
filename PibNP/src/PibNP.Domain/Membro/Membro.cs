using PibNP.Domain.Enderecos;
using PibNP.Domain.Membro.ValueObjects;
using System;

namespace PibNP.Domain.Membro
{
    public class Membro
    {
        #region Properties

        public string Nome { get; private set; }

        public Email Email { get; private set; }

        public DateTime? Aniversario { get; private set; }

        public DateTime? Batismo { get; private set; }

        public Telefone Residencial { get; private set; }

        public Telefone Celular { get; private set; }

        public Telefone Comercial { get; private set; }

        public Sexo Sexo { get; private set; }

        public EstadoCivil Status { get; private set; }

        public Cpf Cpf { get; private set; }

        public Rg Rg { get; private set; }

        private Endereco endereco;

        public Endereco GetEndereco()
        {
            return endereco;
        }

        private void SetEndereco(Endereco value)
        {
            endereco = value;
        }

        public string Foto { get; private set; }

        #endregion

        #region Constructors

        public Membro()
        {
            this.Nome = null;
            this.Email = null;
            this.Aniversario = null;
            this.Batismo = null;
            this.Residencial = null;
            this.Celular = null;
            this.Comercial = null;
            this.Sexo = Sexo.Masculino;
            this.Status = EstadoCivil.Solteiro;
            this.Cpf = null;
            this.Rg = null;
            this.SetEndereco(null);
        }

        private Membro(string nome, Email email, DateTime aniversario, DateTime batismo, Telefone Residencial, Telefone Celular, Telefone Comercial, Sexo Sexo, EstadoCivil Status, Cpf Cpf, Rg Rg, Endereco Endereco) : this()
        {

        }

        #endregion

        #region Factor

        public static class Factor
        {
            public static Membro Create(string nome, Email email, DateTime aniversario, DateTime batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil status, Cpf cpf, Rg rg, Endereco endereco)
            {
                return new Membro(nome, email, aniversario, batismo, residencial, celular, comercial, sexo, status, cpf, rg, endereco);
            }
        }

        #endregion
    }
}
