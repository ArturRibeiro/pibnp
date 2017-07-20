using System;
using System.Collections.Generic;
using System.Text;

namespace PibNP.Domain.Core.ValueObjects
{
    public class Telefone
    {
        #region Properties
        public string Value { get; private set; }

        public bool Valido { get; private set; }
        #endregion

        public Telefone(string telefone)
        {
            if (Validar(telefone))
            {
                Valido = false;
            }
            else
            {
                Valido = true;
                this.Value = telefone;
            }
        }

        private bool Validar(string telefone)
        {
            return false;
        }
    }
}
