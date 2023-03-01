using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> candles = new List<int> ();
            for (int i = 0;i < n; i++)
            {
                candles.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int result = birthdayCakeCandles(candles);
            Console.WriteLine(result);
        }
        public static int birthdayCakeCandles( List<int>candles)
        {
            {
                int count = 0;
                var max = candles.Max();
                for (int i = 0; i < candles.Count; i++)
                {
                    if (candles[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
