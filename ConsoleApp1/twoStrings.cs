using System;

namespace ConsoleApp1
{
    public class TwoStrings
    {
        public static string GetTwoStrings(string s1, string s2)
        {
            var tuple = ReturnBigStringSmallArrayTuple(s1, s2);
            var foundMatch = tuple.Item1.IndexOfAny(tuple.Item2) > -1;

            return foundMatch ? "YES" : "NO";
            
            // while (!foundMatch)
            // {
            //     for (var i = 0; i < smallArray.Length; i++)
            //     {
            //         var smallChar = smallArray[i];
            //         foundMatch = bigString.Contains(smallChar);
            //     }
            //
            // }
            // return foundMatch ? "YES" : "NO";
        }



        public static Tuple<string, char[]> ReturnBigStringSmallArrayTuple(string s1, string s2)
        {
            var firstIsBigger = s1.Length > s2.Length;
            return Tuple.Create(
                firstIsBigger ? s1 : s2, 
                firstIsBigger ? s2.ToCharArray() : s1.ToCharArray()
            );
        }
    }
}