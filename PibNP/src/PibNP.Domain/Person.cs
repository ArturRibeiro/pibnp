using System;

namespace PibNP.Domain
{
    public class Person
    {
        #region Properties

        public string Name { get; private set; }

        #endregion

        #region Constructors

        private Person(string name)
        {
            Name = name;
        }

        #endregion

        #region Factor

        public static class Factor
        {
            public static Person Create(string name)
            {
                return new Person(name);
            }
        }

        #endregion
    }
}
