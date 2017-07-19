﻿using PibNP.Domain.Membro.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PibNP.UnitTest._4___Domain_Membro_ValueObjects
{
    public class EmailTest
    {
        [Theory]
        [InlineData("m_a1a@hostname.com")]
        [InlineData("ma.h.saraf.onemore@hostname.com.edu")]
        [InlineData("ma@hostname.com")]
        [InlineData("ma12@hostname.com")]
        [InlineData("ma-a.aa@hostname.com.edu")]
        [InlineData("ma-a@hostname.com")]
        [InlineData("ma-a@hostname.com.edu")]
        [InlineData("ma-a@1hostname.com")]
        [InlineData("ma.a@1hostname.com")]
        [InlineData("ma@1hostname.com")]
        [InlineData("artur.ribeiro@gmail.com")]
        [InlineData("artur.ribeiro@gmail.com.br")]
        [InlineData("nlalinha@xx.com")]
        public void EmailsValidos(string emailInformado)
        {
            var email = new Email(emailInformado);

            Assert.Equal(email.Valido, true);
            Assert.Equal(email.Value, emailInformado);
        }

        [Theory]
        [InlineData("m.a @hostname.co")]
        [InlineData("@majjf.com")]
        [InlineData("A @b@c @example.com")]
        [InlineData("Abc.example.com")]
        [InlineData("js* @proseware.com")]
        [InlineData("js @proseware..com")]
        [InlineData("ma@@jjf.com")]
        [InlineData("ma @jjf.")]
        [InlineData("ma @jjf..com")]
        [InlineData("ma @jjf.c")]
        [InlineData("ma_ @jjf")]
        [InlineData("ma_ @jjf.")]
        [InlineData("-------")]
        [InlineData("j @proseware.com9")]
        [InlineData("js @proseware.com9")]
        [InlineData("js @proseware.com9")]
        [InlineData("js#internal@proseware.com")]
        [InlineData("ma @hostname.comcom")]
        [InlineData("MA @hostname.coMCom")]
        [InlineData("artur.ribeiro@.xx")]
        [InlineData("artur.ribeiro@gmail")]
        [InlineData("nlalinha@jjjjj")]
        public void EmailsInvalidos(string emailInformado)
        {
            var email = new Email(emailInformado);

            Assert.Equal(email.Valido, false);
            Assert.Equal(email.Value, null);
        }
    }
}