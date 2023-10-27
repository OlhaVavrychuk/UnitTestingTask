namespace UnitTestingTask
{
    public class MaxNumberOfUniqueCharacters : ISymbolsCounter
    {
        public int Count(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if(input.Length == 1) 
            {
                return 1;
            }
            return input.Split('\n').Max(line =>
            {
                if(string.IsNullOrEmpty(line))
                {
                    return 0;
                }

                if (input.Length == 1)
                {
                    return 1;
                }

                List<char> unique = new List<char>();
                unique.Add(line[0]);
                int max = 1;

                for(int i=1; i<line.Length; i++)
                {
                    if (unique.Contains(line[i]))
                    {
                        max = Math.Max(max, unique.Count);
                        unique.Clear();
                    }
                    unique.Add(line[i]);
                }
                return max;
            });
        }
    }
}
