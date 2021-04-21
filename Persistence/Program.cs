using System;

namespace Persistence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(10));
        }

        public static int Persistence(long n)
        {
            if(n < 10) return 0;
            var counter =0;
            double multiplier = 1;
            while (!(n<10))
            {
                var newNum = n.ToString(); //string[] ascii 2,3
                foreach (var item in newNum)
                {
                    multiplier *= Char.GetNumericValue(item);
                }
                ++counter;
                n = Convert.ToInt32(multiplier); 
                multiplier = 1;
            }


            return counter;
        }
    }
}
