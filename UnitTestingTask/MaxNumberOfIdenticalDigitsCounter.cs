namespace UnitTestingTask
{
    public class MaxNumberOfIdenticalDigitsCounter : ISymbolsCounter
    {
        private static readonly MaxNumberIdenticalSymbolsWithConditionCounter _counter = new MaxNumberIdenticalSymbolsWithConditionCounter();
        public int Count(string input)
        {
            return _counter.Count(input, Char.IsDigit);
        }
    }
}

