using System.Collections.Generic;
using System.Linq;

namespace PibNP.Domain.Core.ValueObjects
{
    public class Cpf
    {
        public const int CPF_MAX_LENGTH = 11;

        #region Properties
        public string Value { get; private set; }

        public bool Valido { get; private set; }

        public string Mensagem { get; private set; }
        #endregion

        private Cpf()
        {
            this.Valido = false;
            this.Value = null;
        }

        public Cpf(string cpf) : this()
        {
            this.Value = new CpfOnlyNumbers(cpf).ToString();
            this.Valido = this.Validar();
        }

        private bool Validar()
        {
            if (!IsSizeValid()) return false;
            if (TemDigitosRepetidos()) return false;
            return TemNumerosDeVerificaçãoValidos();
        }

        private bool IsSizeValid()
        {
            return this.Value.Length == CPF_MAX_LENGTH;
        }

        private bool TemDigitosRepetidos()
        {
            string[] numerosInvalidos =
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };

            return numerosInvalidos.Contains(this.Value);
        }

        private bool TemNumerosDeVerificaçãoValidos()
        {
            string number = this.Value.Substring(0, CPF_MAX_LENGTH - 2);

            var digitoVerificador = new CpfDigitoVerificador(number)
                                        .ComMultiplicadoresDeAte(2, 11)
                                        .Substituindo("0", 10, 11);

            string firstDigit = digitoVerificador.CalculaDigito();

            digitoVerificador.AddDigito(firstDigit);

            string secondDigit = digitoVerificador.CalculaDigito();

            return string.Concat(firstDigit, secondDigit) == this.Value.Substring(CPF_MAX_LENGTH - 2, 2);
        }
    }
}