using NUnit.Framework;

namespace UnitTestingTask.Tests
{
    [TestFixture]
    public class MaxNumberOfIdenticalLatinLettersCounterTests
    {
        [TestCaseSource(typeof(TestCasesData), nameof(TestCasesData.TestCasesForIdenticalLatinLettersCounter))]
        public void IsValidTests(string source, int result)
        {
            var counter = new MaxNumberOfIdenticalLatinLettersCounter();
            Assert.AreEqual(result, counter.Count(source));
        }
    }
}
