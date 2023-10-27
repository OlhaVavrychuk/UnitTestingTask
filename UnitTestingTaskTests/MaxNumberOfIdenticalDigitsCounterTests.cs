using NUnit.Framework;

namespace UnitTestingTask.Tests
{
    [TestFixture]
    public class MaxNumberOfIdenticalDigitsCounterTests
    {
        [TestCaseSource(typeof(TestCasesData), nameof(TestCasesData.TestCasesForIdenticalDigitsCounter))]
        public void IsValidTests(string source, int result)
        {
            var counter = new MaxNumberOfIdenticalDigitsCounter();
            Assert.AreEqual(result, counter.Count(source));
        }
    }
}
