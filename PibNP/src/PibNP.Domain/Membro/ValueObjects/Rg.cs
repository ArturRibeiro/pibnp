namespace PibNP.Domain.Membro.ValueObjects
{
    public class Rg
    {
        #region Properties
        public string Value { get; private set; }

        public bool Valido { get; private set; }
        #endregion

        public Rg(string rg)
        {
            if (Validar(rg))
            {
                Valido = false;
            }
            else
            {
                Valido = true;
                this.Value = rg;
            }
        }

        private bool Validar(string cpf)
        {
            return false;
        }
    }
}