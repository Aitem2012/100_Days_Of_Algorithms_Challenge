using System;
using System.Linq;

namespace DuplicateCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int DuplicateCount(string str)
        {
            var myStr = str.ToLower().Distinct();
            var count = 0;
            foreach (var item in myStr)
            {
                var counter = 0;
                foreach (var item1 in str.ToLower())
                {
                    if (item == item1)
                    {
                        counter += 1;
                    }
                }
                if (counter > 1)
                {
                    count +=1;
                }
            }


            return count;
        }
    }
}
