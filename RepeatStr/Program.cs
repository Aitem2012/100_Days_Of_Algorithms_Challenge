using System;
using System.Linq;

namespace RepeatStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatStr(5, "Hello"));
        }

        public static String repeatStr(int repeat, string strng)
        {
            
            return string.Concat(Enumerable.Repeat(strng, repeat));
        }
    }
}
