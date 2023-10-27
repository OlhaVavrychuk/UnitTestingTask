using NUnit.Framework;

namespace UnitTestingTask.Tests
{
    public static class TestCasesData
    {
        public static IEnumerable<TestCaseData> TestCasesForIdenticalDigitsCounter
        {
            get
            {
                yield return new TestCaseData("    ", 0);
                yield return new TestCaseData("", 0);
                yield return new TestCaseData("12345",1);
                yield return new TestCaseData("112233", 2);
                yield return new TestCaseData("11122333344", 4);
                yield return new TestCaseData("998877", 2);
                yield return new TestCaseData("123321", 2);
                yield return new TestCaseData("5555555", 7);
                yield return new TestCaseData("0000", 4);
                yield return new TestCaseData("987654321", 1);
                yield return new TestCaseData("111000111", 3);
                yield return new TestCaseData("999888777666555444", 3);
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForUnequalConsecutiveCharactersCounter
        {
            get
            {
                yield return new TestCaseData("    ", 1);
                yield return new TestCaseData("", 0);
                yield return new TestCaseData("abcde", 5);
                yield return new TestCaseData("aabbcc", 2);
                yield return new TestCaseData("aaaabbbb", 2);
                yield return new TestCaseData("xyzxyzxyz", 3);
                yield return new TestCaseData("1234567890", 10);
                yield return new TestCaseData("aaaAAAbbbBBB", 2);
                yield return new TestCaseData("ababababab", 2);
                yield return new TestCaseData("aaaaa", 1);
                yield return new TestCaseData("abcABCabcABC", 6);
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForIdenticalLatinLettersCounter
        {
            get
            {
                yield return new TestCaseData("    ", 0);
                yield return new TestCaseData("", 0);
                yield return new TestCaseData("abcdefg", 1);
                yield return new TestCaseData("aabccdd", 2);
                yield return new TestCaseData("abcdddef", 3);
                yield return new TestCaseData("xxyyyyzz", 4);
                yield return new TestCaseData("abcdefgh", 1);
                yield return new TestCaseData("aaAAaaBBB", 3);
                yield return new TestCaseData("aabbccDDEEFF", 2);
                yield return new TestCaseData("aaaBBBcccDDD", 3);
                yield return new TestCaseData("xyzXYZxyz", 1);
                yield return new TestCaseData("aaaaaBBBbbCCCcc", 5);
            }
        }
    }
}
