using Pib.NP.Domain.Core.ValueObjects;
using Xunit;

namespace Pib.NP.UnitTest._4___Domain_Core_ValueObjects
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

