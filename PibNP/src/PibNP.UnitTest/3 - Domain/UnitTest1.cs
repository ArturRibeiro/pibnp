using PibNP.Domain;
using System;
using Xunit;

namespace PibNP.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var person = Person.Factor.Create("Artur Ara�jo Santos Ribeiro");

            Assert.Equal(person.Name, "Artur Ara�jo Santos Ribeiro");
            
        }
    }
}
