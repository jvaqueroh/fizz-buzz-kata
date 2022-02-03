using NUnit.Framework;

namespace FizzBuzzKata.Tests {
    public class FizzBuzzShould {
        [Test]
        public void returns_1_as_string()
        {
            string result = FizzBuzz.NumberToText(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void returns_2_as_string()
        {
            var result = FizzBuzz.NumberToText(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void returns_FIZZ_for_3()
        {
            var result = FizzBuzz.NumberToText(3);
            Assert.AreEqual("FIZZ", result);
        }

        [Test]
        public void returns_4_as_string()
        {
            var result = FizzBuzz.NumberToText(4);
            Assert.AreEqual("4", result);
        }
    }
}
