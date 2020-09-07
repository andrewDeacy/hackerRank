using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class birthdayCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            var max = 0;
            var maxCount = 0;

            for (var i = 0; i < candles.Count; i++)
            {
                var candle = candles.ElementAt(i);
                if (candle > max)
                {
                    max = candle;
                    maxCount = 1;
                }  else if (candle == max)
                {
                    maxCount++;
                }
            }

            return maxCount;
        }
    }
}