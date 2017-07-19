using PibNP.Domain.Membro.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PibNP.UnitTest._4___Domain.Membro.ValueObjects
{
    public class CpfTest
    {
        [Theory]
        [InlineData("09436015763")]
        [InlineData("57203337979")]
        [InlineData("98677475699")]
        [InlineData("24354427770")]
        [InlineData("53214590537")]
        [InlineData("11526612488")]
        public void CpfValido(string cpfInformado)
        {
            Cpf cpf = new Cpf(cpfInformado);

            Assert.Equal(cpf.Valido, true);
        }
    }
}

