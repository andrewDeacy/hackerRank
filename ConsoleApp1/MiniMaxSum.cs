using System;

namespace ConsoleApp1
{
    public class MiniMaxSum
    {
        public static int[] miniMaxSum(int[] arr)
        {
            var min = 0;
            var max = 0;
            var sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (i == 0)
                {
                    min = arr[i];
                    max = arr[i];
                } else if (arr[i] < min)
                {
                    min = arr[i];
                } else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"{sum - max} {sum - min}");

            return new []{ sum - max, sum - min };
        }

    }
}