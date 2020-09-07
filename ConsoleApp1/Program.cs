using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        var swaps = 0;
        var min = arr[0];
        var max = 0;
        var length = arr.Length;
        var sorted = new int[length];

        // look at value before and after
        for (int i = 0; i < length; i++)
        {
            if (i == 0)
            {
                sorted = arr;
            }
            else if (i != length)
            {
                var item = sorted[i];
                var valueBefore = sorted[i - 1];
                var valueAfter = sorted[i + 1];

                if (item < valueBefore)
                {
                    sorted[i - 1] = item;
                    sorted[i] = valueBefore;
                    swaps++;

                    if (valueAfter > valueBefore)
                    {
                        sorted[i + 1] = valueAfter;

                        swaps++;
                    }
                }

            }

        }

        return swaps;
    }

    // public static void Main(string[] args) {
    //     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //
    //     int n = Convert.ToInt32(Console.ReadLine());
    //
    //     int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    //     int res = minimumSwaps(arr);
    //
    //     textWriter.WriteLine(res);
    //
    //     textWriter.Flush();
    //     textWriter.Close();
    // }
}
