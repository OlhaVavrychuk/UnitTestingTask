namespace UnitTestingTask
{
    public class MaxNumberOfIdenticalSymbolsWithConditionCounter
    {
        public int Count(string input, Func<char, bool> predicate)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int nextValidPosition = input.IndexOf(predicate);
            //no valid symbols 
            if (nextValidPosition == -1)
            {
                return 0;
            }

            int max = 1;
            int current = 1;
            char letter = input[nextValidPosition];

            for (int i = nextValidPosition + 1; i < input.Length;)
            {
                if (predicate(input[i]))
                {
                    if (letter == input[i])
                    {
                        current += 1;
                    }
                    else
                    {
                        max = Math.Max(max,current);
                        letter = input[i];
                        current = 1;
                    }
                    i++;
                }
                else
                {
                    nextValidPosition = input.IndexOf(predicate, i);
                    if (nextValidPosition == -1)
                    {
                        max = Math.Max(max, current);
                        break;
                    }
                    else
                    {
                        i = nextValidPosition + 1;
                        max = Math.Max(max, current);
                        letter = input[nextValidPosition];
                        current = 1;
                    }
                }
            }
            max = Math.Max(max, current);
            return max;
        }
    }
}
