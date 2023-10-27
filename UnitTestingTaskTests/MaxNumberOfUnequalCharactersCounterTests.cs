using NUnit.Framework;

namespace UnitTestingTask.Tests
{
    [TestFixture]
    public class MaxNumberOfUnequalCharactersCounterTests
    {
        [TestCaseSource(typeof(TestCasesData), nameof(TestCasesData.TestCasesForUnequalConsecutiveCharactersCounter))]
        public void IsValidTests(string source, int result)
        {
            var counter = new MaxNumberOfUnequalCharactersCounter();
            Assert.AreEqual(result, counter.Count(source));
        }
    }
}
