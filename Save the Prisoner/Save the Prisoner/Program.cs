using System;

namespace Save_the_Prisoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(saveThePrisoner(7, 22, 2));
        }
        public static int saveThePrisoner(int n, int m, int s)
        {
            int rest = m % n;
            if ((rest + s - 1) % n == 0)
            {
                return n;
            }
            else
            {
                return ((rest + s - 1) % n);
            }
        }
    }
}
