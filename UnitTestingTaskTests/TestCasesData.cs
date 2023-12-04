using NUnit.Framework;

namespace UnitTestingTask.Tests
{
    public static class TestCasesData
    {
        public static IEnumerable<TestCaseData> TestCasesForIdenticalDigitsCounter
        {
            get
            {
                yield return new TestCaseData(null, 0);
                yield return new TestCaseData("", 0);
                yield return new TestCaseData("1",1);
                yield return new TestCaseData("22aaa", 2);
                yield return new TestCaseData("aaa33aaa", 2);
                yield return new TestCaseData("aaaa44", 2);
                yield return new TestCaseData("55566", 3);
                yield return new TestCaseData("77888", 3);
                yield return new TestCaseData("99999", 5);
                yield return new TestCaseData("9876543210", 1);
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForUnequalConsecutiveCharactersCounter
        {
            get
            {
                yield return new TestCaseData("", 0);
                yield return new TestCaseData(null, 0);
                yield return new TestCaseData("a", 1);
                yield return new TestCaseData("bc", 2);
                yield return new TestCaseData("Dd", 2);
                yield return new TestCaseData("efgeee", 3);
                yield return new TestCaseData("hiklgkmno", 6);
                yield return new TestCaseData("pqrtsuvrqp", 7);
                yield return new TestCaseData("wxyz", 4);
                yield return new TestCaseData("abcABCabcABC", 6);
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForIdenticalLatinLettersCounter
        {
            get
            {
                yield return new TestCaseData(null, 0);
                yield return new TestCaseData("", 0);
                yield return new TestCaseData("1", 0);
                yield return new TestCaseData("A", 1);
                yield return new TestCaseData("1111aaaAA", 3);
                yield return new TestCaseData("111aaAAA", 3);
                yield return new TestCaseData("AAAAA", 5);
                yield return new TestCaseData("AAA11111", 3);
            }
        }
    }
}
