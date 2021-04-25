using System;

namespace CuboidVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int FindDifference(int[] a, int[] b)
        {
            //loading...
            var aMult = 1;
            var bMult = 1;
            foreach (var num in a)
                aMult *= num;
            foreach (var num in b)
                bMult *= num;
            return Math.Abs(aMult - bMult);
        }
    }
}
