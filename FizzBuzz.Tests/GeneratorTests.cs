using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        private IList<string> numbers;

        [SetUp]
        public void Setup()
        {
            var generator = new Generator();
            numbers = generator.Generate();
        }

        [Test]
        public void GenerateList_ShouldReturn100Items()
        {
            Assert.AreEqual(100, numbers.Count);
        }

        [Test]
        public void GenerateList_ShouldReturn1()
        {
            Assert.AreEqual("1", numbers[0]);
        }

        [Test]
        public void GenerateList_ThirdItemShouldBeFizz()
        {
            Assert.AreEqual("Fizz", numbers[2]);
        }

        [Test]
        public void GenerateList_SixthItemShouldBeFizz()
        {
            Assert.AreEqual("Fizz", numbers[5]);
        }

        [Test]
        public void GenerateList_FifthItemShouldBeBuzz()
        {
            Assert.AreEqual("Buzz", numbers[4]);
        }

        [Test]
        public void GenerateList_FifteenthItemShouldBeFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", numbers[14]);
        }


    }
}