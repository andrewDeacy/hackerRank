using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class swaps
    {
        public static int minimumSwaps(int[] arr)
        {
            // hash map of value + position
            var hashMap = new Dictionary<int, int>();
            var visited = new bool[arr.Length + 1];

            // create actual value + (non-zero based) position hash map:
            for (var i = 1; i < visited.Length; i++)
            {
                hashMap.Add(i, arr[i - 1]);
            }

            var swapCount = 0;

            for (var j = 1; j < hashMap.Count; j++)
            {
                if (visited[j]) continue;
                visited[j] = true;

                // if actual value = position, then we do not need to make a swap!
                if (hashMap[j] == j) continue;

                var value = hashMap[j];

                while (!visited[value]) // keep checking values of 'inverses' until we find a visited one
                {
                    visited[value] = true;
                    value = hashMap[value];
                    swapCount++;
                }
            }

            return swapCount;
        }
    }
}