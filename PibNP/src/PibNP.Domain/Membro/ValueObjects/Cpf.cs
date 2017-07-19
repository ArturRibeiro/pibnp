namespace PibNP.Domain.Membro.ValueObjects
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
            if (Validar(cpf))
            {
                this.Valido = false;
            }
            else
            {
                this.Valido = true;
                this.Value = cpf;
            }
        }

        private bool Validar(string cpf)
        {
            //Implementar Logica de validação
            return false;
        }
    }
}