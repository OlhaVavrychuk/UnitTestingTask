namespace UnitTestingTask
{
    public static class StringHelper
    {
        public static int IndexOf(this string line, Func<char, bool> predicate, int startIndex = 0)
        {
            int current = -1;
            for (int i = startIndex; i < line.Length; i++)
            {
                if (predicate(line[i]))
                {
                    current = i;
                    break;
                }
            }

            return current;
        }
    }
}

