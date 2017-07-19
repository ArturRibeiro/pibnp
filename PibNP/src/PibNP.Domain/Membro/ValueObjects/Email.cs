using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PibNP.Domain.Membro.ValueObjects
{
    public class Email
    {
        private const string EMAIL_PATTERN = @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$";
        private const int EMAIL_MAX_LENGTH = 254;
        private const int EMAIL_MIN_LENGTH = 5;

        #region Properties
        public string Value { get; private set; }

        public bool Valido { get; private set; }
        #endregion

        public Email(string email)
        {
            if (Validar(email))
            {
                Valido = false;
            }
            else
            {
                Valido = true;
                this.Value = email;
            }
        }

        private bool Validar(string email)
        {
            return Regex.IsMatch(email, EMAIL_PATTERN);
        }
    }
}
