using System.Collections;
using System.Diagnostics;
using NUnit.Framework;

namespace FizzBuzzKata.Tests {
    [TestFixtureSource(typeof(MyFixtureData), nameof(MyFixtureData.Fixtureparams))]
    public class FizzBuzzShould {
        private readonly int value;
        private readonly string expectedResult;

        public FizzBuzzShould(int value, string expectedResult)
        {
            this.value = value;
            this.expectedResult = expectedResult;
        }

        [Test]
        public void returns_expected_string_value()
        {
            var result = FizzBuzzer.FizzBuzz(value);
            Assert.AreEqual(expectedResult, result);
        }
    }

    public class MyFixtureData
    {
        public static IEnumerable Fixtureparams {
            get {
                yield return new TestFixtureData(1,   "1");
                yield return new TestFixtureData(2,   "2");
                yield return new TestFixtureData(3,   "FIZZ");
                yield return new TestFixtureData(4,   "4");
                yield return new TestFixtureData(5,   "BUZZ");
                yield return new TestFixtureData(6,   "FIZZ");
                yield return new TestFixtureData(7,   "7");
                yield return new TestFixtureData(8,   "8");
                yield return new TestFixtureData(9,   "FIZZ");
                yield return new TestFixtureData(10,  "BUZZ");
                yield return new TestFixtureData(15,  "FIZZBUZZ");
                yield return new TestFixtureData(20,  "BUZZ");
                yield return new TestFixtureData(30,  "FIZZBUZZ");
                yield return new TestFixtureData(45,  "FIZZBUZZ");
                yield return new TestFixtureData(77,  "77");
                yield return new TestFixtureData(99,  "FIZZ");
                yield return new TestFixtureData(100, "BUZZ");
            }
        }
    }
}
