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

        [Test]
        public void GenerateList_ThirdItemShouldBeFizz()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual("Fizz", numbers[2]);
        }

        [Test]
        public void GenerateList_SixthItemShouldBeFizz()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual("Fizz", numbers[5]);
        }

        [Test]
        public void GenerateList_FifthItemShouldBeBuzz()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual("Buzz", numbers[4]);
        }

        [Test]
        public void GenerateList_FifteenthItemShouldBeFizzBuzz()
        {
            var generator = new Generator();
            var numbers = generator.Generate();

            Assert.AreEqual("FizzBuzz", numbers[14]);
        }


    }
}