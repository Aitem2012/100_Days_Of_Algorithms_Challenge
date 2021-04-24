using System;

namespace SumMix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int SumMix(object[] x)
        {
            var sum =0;
            foreach (var item in x)
            {
                sum += (int)item;
            }
            return sum;
        }
    }
}
