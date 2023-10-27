namespace UnitTestingTask
{
    public class MaxNumberIdenticalSymbolsWithConditionCounter
    {
        public int Count(string input, Func<char, bool> predicate)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return input.Split('\n').Max(line =>
            {
                if (string.IsNullOrEmpty(line))
                {
                    return 0;
                }

                int nextValidPosition = line.IndexOf(predicate);
                //no valid symbols in this line
                if (nextValidPosition == -1)
                {
                    return 0;
                }

                int max = 1;
                int current = 1;
                char letter = line[nextValidPosition];

                for (int i = nextValidPosition + 1; i < line.Length;)
                {
                    if (predicate(line[i]))
                    {
                        if (letter == line[i])
                        {
                            current += 1;
                        }
                        else
                        {
                            max = Math.Max(current, letter);
                            letter = line[i];
                            current = 1;
                        }
                        i++;
                    }
                    else
                    {
                        nextValidPosition = line.IndexOf(predicate, i + 1);
                        if (nextValidPosition == -1)
                        {
                            max = Math.Max(max, current);
                            break;
                        }
                        else
                        {
                            i = nextValidPosition + 1;
                            max = Math.Max(current, letter);
                            letter = line[nextValidPosition];
                            current = 1;
                        }
                    }
                }
                return max;
            });

        }
    }
}
