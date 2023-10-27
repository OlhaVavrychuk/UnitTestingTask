using System.IO.Pipes;

namespace UnitTestingTask
{
    public class MaxNumberOfIdenticalLatinLetters : ISymbolsCounter
    {
        private static readonly MaxNumberIdenticalSymbolsWithConditionCounter _counter = new MaxNumberIdenticalSymbolsWithConditionCounter();
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
