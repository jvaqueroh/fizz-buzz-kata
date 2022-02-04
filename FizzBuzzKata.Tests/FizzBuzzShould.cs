using NUnit.Framework;

namespace FizzBuzzKata.Tests {
    public class FizzBuzzShould {
        [Test]
        public void returns_1_as_string()
        {
            string result = FizzBuzzer.FizzBuzz(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void returns_2_as_string()
        {
            var result = FizzBuzzer.FizzBuzz(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void returns_FIZZ_for_3()
        {
            var result = FizzBuzzer.FizzBuzz(3);
            Assert.AreEqual("FIZZ", result);
        }

        [Test]
        public void returns_4_as_string()
        {
            var result = FizzBuzzer.FizzBuzz(4);
            Assert.AreEqual("4", result);
        }

        [Test]
        public void returns_BUZZ_for_5()
        {
            var result = FizzBuzzer.FizzBuzz(5);
            Assert.AreEqual("BUZZ", result);
        }

        [Test]
        public void returns_FIZZ_for_6()
        {
            var result = FizzBuzzer.FizzBuzz(6);
            Assert.AreEqual("FIZZ", result);
        }

        [Test]
        public void returns_FIZZ_for_9()
        {
            var result = FizzBuzzer.FizzBuzz(9);
            Assert.AreEqual("FIZZ", result);
        }

        [Test]
        public void returns_BUZZ_for_10()
        {
            var result = FizzBuzzer.FizzBuzz(10);
            Assert.AreEqual("BUZZ", result);
        }

        [Test]
        public void returns_FIZZ_for_20()
        {
            var result = FizzBuzzer.FizzBuzz(20);
            Assert.AreEqual("BUZZ", result);
        }
    }
}
