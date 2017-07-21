using PibNP.Domain.Core.ValueObjects;
using PibNP.Domain.Organizacao;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PibNP.UnitTest._4___Domain_Igreja
{
    public class IgrejaTest
    {
        [Theory]
        [InlineData("Primeira Igreja Batista em Nova Piam", "", "contato@pibnp.com.br", "552122222222")]
        public void Criar_Igreja(string nome, string foto, string infEmail, string infTelefone)
        {
            var email = new Email(infEmail);
            var telefone = new Telefone(infTelefone);

            var igreja = Igreja.Factor.Create(nome, foto, email, telefone);
            
            Assert.Equal(nome, igreja.Nome);
            Assert.Equal(foto, igreja.Foto);
            Assert.Equal(email.Value, igreja.Email.Value);
            Assert.Equal(telefone.Value, igreja.Telefone.Value);
        }
    }
}
