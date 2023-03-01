using System;

namespace Sherlock_and_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int result = squares(a, b);
            Console.WriteLine(result);
        }
       public static int squares(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                int j = 1;
                while (j * j <= i)
                {
                    if (j * j == i)
                    {
                        count++;
                        break;
                    }
                    j++;
                }
            }
            return count;
        }

    }
}
