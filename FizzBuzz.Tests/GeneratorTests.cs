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
        public void GenerateList_ShouldReturn100Items()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual(100, numbers.Count);
        }

        [Test]
        public void GenerateList_ShouldReturn1()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual("1", numbers[0]);
        }


    }
}