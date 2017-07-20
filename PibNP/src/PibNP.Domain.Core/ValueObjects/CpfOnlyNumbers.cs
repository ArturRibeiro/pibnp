using System;
using System.Collections.Generic;
using System.Text;

namespace PibNP.Domain.Core.ValueObjects
{
    public class CpfOnlyNumbers
    {
        private string value;

        public CpfOnlyNumbers(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            string onlyNumber = "";
            foreach (char s in this.value)
            {
                if (Char.IsDigit(s))
                {
                    onlyNumber += s;
                }
            }
            return onlyNumber.Trim();
        }
    }
}
