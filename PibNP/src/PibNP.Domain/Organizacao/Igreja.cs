using Pib.NP.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pib.NP.Domain.Organizacao
{
    public class Igreja
    {
        #region Propriedades
        public string Nome { get; private set; }
        public string Foto { get; private set; }
        public Email Email { get; private set; }
        public Telefone Telefone { get; private set; }
        public IgrejaEndereco Endereco { get; private set; }
        #endregion

        #region Construtores

        private Igreja()
        {
            this.Nome = null;
            this.Foto = null;
            this.Email = null;
            this.Telefone = null;
            this.Endereco = null;
        }

        public Igreja(string nome, string foto, Email email, Telefone telefone, IgrejaEndereco endereco) : this()
        {
            this.Nome = nome;
            this.Foto = foto;
            this.Email = email;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }

        public Igreja(string nome, string foto, Email email, Telefone telefone) : this()
        {
            this.Nome = nome;
            this.Foto = foto;
            this.Email = email;
            this.Telefone = telefone;
        }

        #endregion

        #region Factor
        public static class Factor
        {
            public static Igreja Create(string nome, string foto, Email email, Telefone telefone, IgrejaEndereco endereco)
            {
                return new Igreja(nome, foto, email, telefone, endereco);
            }

            public static Igreja Create(string nome, string foto, Email email, Telefone telefone)
            {
                return new Igreja(nome, foto, email, telefone);
            }
        }
        #endregion
    }
}
