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

        /* Generate */
        [Test]
        public void Generate_ShouldReturn100Items()
        {
            Assert.AreEqual(100, numbers.Count);
        }

        [Test]
        public void Generate_ShouldReturn1()
        {
            Assert.AreEqual("1", numbers[0]);
        }

        [Test]
        public void Generate_ThirdItemShouldBeFizz()
        {
            Assert.AreEqual("Fizz", numbers[2]);
        }

        [Test]
        public void Generate_SixthItemShouldBeFizz()
        {
            Assert.AreEqual("Fizz", numbers[5]);
        }

        [Test]
        public void Generate_FifthItemShouldBeBuzz()
        {
            Assert.AreEqual("Buzz", numbers[4]);
        }

        [Test]
        public void Generate_FifteenthItemShouldBeFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", numbers[14]);
        }

        /* TextToDisplay */
        [Test]
        public void TextToDisplay_15ShouldReturnFizzBuzz()
        {
            var generator = new Generator();
            var displayText = generator.TextToDisplay(30);
            Assert.AreEqual("FizzBuzz", displayText);
        }

        [Test]
        public void TextToDisplay_9ShouldReturnFizzBuzz()
        {
            var generator = new Generator();
            var displayText = generator.TextToDisplay(9);
            Assert.AreEqual("Fizz", displayText);
        }

        [Test]
        public void TextToDisplay_35ShouldReturnFizzBuzz()
        {
            var generator = new Generator();
            var displayText = generator.TextToDisplay(35);
            Assert.AreEqual("Buzz", displayText);
        }

        [Test]
        public void TextToDisplay_11ShouldReturn11()
        {
            var generator = new Generator();
            var displayText = generator.TextToDisplay(11);
            Assert.AreEqual("11", displayText);
        }

    }
}