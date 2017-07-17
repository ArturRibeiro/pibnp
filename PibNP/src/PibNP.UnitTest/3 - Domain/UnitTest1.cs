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
            var person = Person.Factor.Create("Artur Araújo Santos Ribeiro");

            Assert.Equal(person.Name, "Artur Araújo Santos Ribeiro");
            
        }
    }
}
