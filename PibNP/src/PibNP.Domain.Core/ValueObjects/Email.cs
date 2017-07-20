using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PibNP.Domain.Core.ValueObjects
{
    /// <summary>
    /// 
    /// </summary>
    public class Email
    {
        private const string EMAIL_PATTERN = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const int EMAIL_MAX_LENGTH = 100;
        public const int EMAIL_MIN_LENGTH = 5;

        #region Properties
        public string Value { get; private set; }

        public bool Valido { get; private set; }

        public string Mensagem { get; private set; }
        #endregion

        private Email()
        {
            Valido = false;
            Value = null;
            Mensagem = null;
        }

        public Email(string email) : this()
        {
            Validar(email);
        }

        private void Validar(string email)
        {
            if (email.Length > EMAIL_MAX_LENGTH)
                this.Mensagem = $"E-mail: {email} informado ultrapassou a quantidade permitida de {EMAIL_MAX_LENGTH}";
            else if (email.Length < EMAIL_MIN_LENGTH)
                this.Mensagem = $"E-mail: {email} informado não possui a quantidade permitida de {EMAIL_MIN_LENGTH}";
            else
            {
                var result = Regex.IsMatch(email, EMAIL_PATTERN);

                if (!result)
                {
                    this.Mensagem = "E-mail inváido";
                }
                else
                {
                    this.Valido = true;
                    this.Value = email;
                }
            }
        }
    }
}
