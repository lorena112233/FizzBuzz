using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual(100, numbers.Count);
        }

        public class Generator {

            public Generator(){

            }

            public IList<int> Generate()
            {
                var numbersList = new List<int>();

                for(int i = 0; i< 100; i++){
                    numbersList.Add(i+1);
                }

                return numbersList;
            }
        }
    }
}