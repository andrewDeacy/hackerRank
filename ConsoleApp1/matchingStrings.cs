namespace ConsoleApp1
{
    public class MatchingStrings
    {
        public static int[] getMatchingStrings(string[] strings, string[] queries)
        {
            var counts = new int[queries.Length];
            // loop through each string
            for (var i = 0; i < queries.Length; i++)
            {
                var matches = 0;
                for (var j = 0; j < strings.Length; j++)
                {
                    if (strings[j] == queries[i])
                    {
                        matches++;
                    }
                }

                counts[i] = matches;
            }

            return counts;
        }
    }
}