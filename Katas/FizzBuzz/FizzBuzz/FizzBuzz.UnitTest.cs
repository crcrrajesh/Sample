using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    internal class FizzBuzzGeneratorUnitTest
    {
        [SetUp]
        public void Setup()
        {
			
			
            var rules = new List<IRule>();
            rules.Add(new FizzRule());
            rules.Add(new BuzzRule());
            _fizzBuzz = new FizzBuzzGenerator(rules);
        }

        private FizzBuzzGenerator _fizzBuzz;

        [Test]
        public void NoFizzOrBuzzFromRange()
        {
            var output = string.Join(",", _fizzBuzz.Generate(10, 15));
            Assert.AreEqual("Buzz,11,Fizz,13,14,FizzBuzz", output);
        }

        [Test]
        public void NoFizzOrBuzz()
        {
            Assert.AreEqual("2",_fizzBuzz.GetNumberType(2));
        }

        [Test]
        public void OnlyFizz()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.GetNumberType(3));
        }

        [Test]
        public void OnlyBuzz()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.GetNumberType(5));
        }

        [Test]
        public void BothFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.GetNumberType(15));
        }
    }
}