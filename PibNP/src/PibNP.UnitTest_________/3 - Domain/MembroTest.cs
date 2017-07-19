using PibNP.Domain.Membro;
using PibNP.Domain.Membro.ValueObjects;
using System;
using Xunit;

namespace PibNP.UnitTest
{
    public class MembroTest
    {
        [Fact]
        public void TestMethod1()
        {
            var email = new Email("arturrj@gmail.com");
            var telefoneResidencial = new Telefone("552127620534");
            var telefoneMovel = new Telefone("55212987413978");
            var telefoneComercial = new Telefone("552127620534");
            var cpf = new Cpf("09436015763");
            var rg = new Rg("");
            var endereco = new Endereco();

            var membro = Membro.Factor.Create("Artur Ara�jo Santos Ribeiro"
                , email
                , DateTime.Now
                , DateTime.Now
                , telefoneResidencial
                , telefoneMovel
                , telefoneComercial
                , Sexo.Masculino
                , EstadoCivil.Casado
                , cpf
                , rg
                , endereco);

            Assert.Equal(membro.Nome, "Artur Ara�jo Santos Ribeiro");
            Assert.Equal(membro.Email.Value, "Artur Ara�jo Santos Ribeiro");
            Assert.Equal(membro.Residencial.Value, "Artur Ara�jo Santos Ribeiro");
            Assert.Equal(membro.Celular.Value, "Artur Ara�jo Santos Ribeiro");
            Assert.Equal(membro.Comercial.Value, "Artur Ara�jo Santos Ribeiro");

            //Assert.Equal(membro.Name, "Artur Ara�jo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Ara�jo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Ara�jo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Ara�jo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Ara�jo Santos Ribeiro");

        }
    }
}
