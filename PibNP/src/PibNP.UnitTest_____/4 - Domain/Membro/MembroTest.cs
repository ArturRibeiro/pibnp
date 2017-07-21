using PibNP.Domain.Core.ValueObjects;
using PibNP.Domain.Enderecos;
using PibNP.Domain.Membro;
using System;
using Xunit;

namespace PibNP.UnitTest._4___Domain_Membro
{
    public class MembroTest
    {
        [Fact]
        public void Criar_Membro()
        {
            var nome = "Artur Araújo Santos Ribeiro";
            var email = new Email("arturrj@gmail.com");
            var telefoneResidencial = new Telefone("552127620534");
            var telefoneMovel = new Telefone("55212987413978");
            var telefoneComercial = new Telefone("552127620534");
            var cpf = new Cpf("09436015763");
            var rg = new Rg("");
            var endereco = new Endereco();
            var foto = "";

            var membro = Membro.Factor.Create(nome
                , foto
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

            Assert.Equal(membro.Nome, nome);
            Assert.Equal(membro.Email.Value, email.Value);
            Assert.Equal(membro.Residencial.Value, telefoneResidencial.Value);
            Assert.Equal(membro.Celular.Value, telefoneMovel.Value);
            Assert.Equal(membro.Comercial.Value, telefoneComercial.Value);
            Assert.Equal(membro.Sexo, Sexo.Masculino);
            Assert.Equal(membro.EstadoCivil, EstadoCivil.Casado);
            Assert.Equal(membro.Cpf.Value, cpf.Value);
            Assert.Equal(membro.Rg.Value, rg.Value);
        }

        [Theory]
        [InlineData("Artur Araújo Santos Ribeiro", "", "arturrj@gmail.com", "552127620534", "55212987413978", "552127620534", "09436015763", "123456789")]
        public void InativarMembro(string nome, string foto, string email, string telResidencial, string telMovel, string telComercial, string cpf, string rg)
        {
            var membro = Membro.Factor.Create(nome
                , foto
                , new Email(email)
                , DateTime.Now
                , DateTime.Now
                , new Telefone(telResidencial)
                , new Telefone(telMovel)
                , new Telefone(telComercial)
                , Sexo.Masculino
                , EstadoCivil.Casado
                , new Cpf(cpf)
                , new Rg(rg));

            membro.Inativar();

            Assert.Equal(membro.Situacao, Situacao.Inativo);
        }


        [Theory]
        [InlineData("Artur Araújo Santos Ribeiro", "", "arturrj@gmail.com", "552127620534", "55212987413978", "552127620534", "09436015763", "123456789")]
        public void AtivarMembro(string nome, string foto, string email, string telResidencial, string telMovel, string telComercial, string cpf, string rg)
        {
            var membro = Membro.Factor.Create(nome
                , foto
                , new Email(email)
                , DateTime.Now
                , DateTime.Now
                , new Telefone(telResidencial)
                , new Telefone(telMovel)
                , new Telefone(telComercial)
                , Sexo.Masculino
                , EstadoCivil.Casado
                , new Cpf(cpf)
                , new Rg(rg));

            membro.Ativar();

            Assert.Equal(membro.Situacao, Situacao.Ativo);
        }
    }
}
