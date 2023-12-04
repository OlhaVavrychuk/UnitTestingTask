using System.ComponentModel.DataAnnotations;

namespace UnitTestingTask
{
    public class MaxNumberOfUnequalCharactersCounter : ISymbolsCounter
    {
        public int Count(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if (input.Length == 1)
            {
                return 1;
            }

            List<char> unique = new()
                {
                    input[0]
                };
            int max = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (unique.Contains(input[i]))
                {
                    max = Math.Max(max, unique.Count);
                    var firstIndex = unique.IndexOf(input[i]);
                    for (int j = 0; j <= firstIndex; j++)
                    {
                        unique.RemoveAt(0);
                    }
                }
                unique.Add(input[i]);
            }
            max = Math.Max(max, unique.Count);
            return max;
        }
    }
}
