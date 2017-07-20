using PibNP.Domain.Core.ValueObjects;
using PibNP.Domain.Enderecos;
using System;

namespace PibNP.Domain.Membro
{
    public class Membro
    {
        #region Properties

        public string Nome { get; private set; }

        public string Foto { get; private set; }

        public Situacao Situacao { get; private set; }

        public Email Email { get; private set; }

        public DateTime? Aniversario { get; private set; }

        public DateTime? Batismo { get; private set; }

        public bool Batizado { get; private set; }

        public Telefone Residencial { get; private set; }

        public Telefone Celular { get; private set; }

        public Telefone Comercial { get; private set; }

        public Sexo Sexo { get; private set; }

        public EstadoCivil EstadoCivil { get; private set; }

        public Cpf Cpf { get; private set; }

        public Rg Rg { get; private set; }

        public Endereco Endereco { get; private set; }
        
        #endregion

        #region Constructors

        private Membro()
        {
            this.Nome = null;
            this.Email = null;
            this.Aniversario = null;
            this.Batismo = null;
            this.Residencial = null;
            this.Celular = null;
            this.Comercial = null;
            this.Sexo = Sexo.Masculino;
            this.EstadoCivil = EstadoCivil.Solteiro;
            this.Cpf = null;
            this.Rg = null;
        }

        private Membro(string nome, string foto, Email email, DateTime aniversario, DateTime batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil estadoCivil, Cpf cpf, Rg rg, Endereco endereco) : this()
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
            this.InformarEndereco(endereco);
        }

        private Membro(string nome, string foto, Email email, DateTime aniversario, DateTime batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil estadoCivil, Cpf cpf, Rg rg) : this()
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

        public void Inativar()
        {
            this.Situacao = Situacao.Inativo;
        }

        public void Ativar()
        {
            this.Situacao = Situacao.Ativo;
        }

        #endregion

        #region Métodos
        public void InformarEndereco(Endereco endereco)
        {
            this.Endereco = endereco;
        }


        #endregion

        #region Factor

        public static class Factor
        {
            public static Membro Create(string nome, string foto, Email email, DateTime aniversario, DateTime batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil status, Cpf cpf, Rg rg, Endereco endereco)
            {
                return new Membro(nome, foto, email, aniversario, batismo, residencial, celular, comercial, sexo, status, cpf, rg, endereco);
            }

            public static Membro Create(string nome, string foto, Email email, DateTime aniversario, DateTime batismo, Telefone residencial, Telefone celular, Telefone comercial, Sexo sexo, EstadoCivil status, Cpf cpf, Rg rg)
            {
                return new Membro(nome, foto, email, aniversario, batismo, residencial, celular, comercial, sexo, status, cpf, rg);
            }
        }

        #endregion
    }
}
