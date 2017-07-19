using PibNP.Domain.Enderecos;
using PibNP.Domain.Membro;
using PibNP.Domain.Membro.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PibNP.UnitTest._4___Domain_Membro
{
    public class MembroTest
    {
        [Fact]
        public void Criar_Membro()
        {
            var email = new Email("arturrj@gmail.com");
            var telefoneResidencial = new Telefone("552127620534");
            var telefoneMovel = new Telefone("55212987413978");
            var telefoneComercial = new Telefone("552127620534");
            var cpf = new Cpf("09436015763");
            var rg = new Rg("");
            var endereco = new Endereco();

            var membro = Membro.Factor.Create("Artur Araújo Santos Ribeiro"
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

            Assert.Equal(membro.Nome, "Artur Araújo Santos Ribeiro");
            Assert.Equal(membro.Email.Value, "Artur Araújo Santos Ribeiro");
            Assert.Equal(membro.Residencial.Value, "Artur Araújo Santos Ribeiro");
            Assert.Equal(membro.Celular.Value, "Artur Araújo Santos Ribeiro");
            Assert.Equal(membro.Comercial.Value, "Artur Araújo Santos Ribeiro");

            //Assert.Equal(membro.Name, "Artur Araújo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Araújo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Araújo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Araújo Santos Ribeiro");
            //Assert.Equal(membro.Name, "Artur Araújo Santos Ribeiro");
        }
    }
}
