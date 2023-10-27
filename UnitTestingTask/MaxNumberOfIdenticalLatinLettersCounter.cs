using System.IO.Pipes;

namespace UnitTestingTask
{
    public class MaxNumberOfIdenticalLatinLettersCounter : ISymbolsCounter
    {
        private static readonly MaxNumberOfIdenticalSymbolsWithConditionCounter _counter = new();
        public int Count(string input)
        {
            return _counter.Count(input, this.IsLatinLetter);
        }

        private bool IsLatinLetter(Char letter)
        {
            return letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z';
        }
    }
}
