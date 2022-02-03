using NUnit.Framework;

namespace FizzBuzzKata.Tests {
    public class FizzBuzzShould {
        [Test]
        public void returns_one_as_text_for_1()
        {
            string result = FizzBuzz.NumberToText(1);
            Assert.AreEqual("one", result);
        }

        [Test]
        public void returns_two_as_text_for_2()
        {
            var result = FizzBuzz.NumberToText(2);
            Assert.AreEqual("two", result);
        }
    }
}
