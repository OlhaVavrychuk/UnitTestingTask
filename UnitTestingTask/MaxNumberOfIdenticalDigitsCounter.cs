namespace UnitTestingTask
{
    public class MaxNumberOfIdenticalDigitsCounter : ISymbolsCounter
    {
        private static readonly MaxNumberOfIdenticalSymbolsWithConditionCounter _counter = new();
        public int Count(string input)
        {
            return _counter.Count(input, Char.IsDigit);
        }
    }
}

