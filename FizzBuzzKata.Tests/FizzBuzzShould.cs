using NUnit.Framework;

namespace FizzBuzzKata.Tests {
    public class FizzBuzzShould {
        [Test]
        public void returns_one_as_tests_for_1()
        {
            string result = FizzBuzz.NumberToText(1);
            Assert.AreEqual("one", result);
        }
    }
}
