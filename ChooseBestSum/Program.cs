using System;
using System.Collections.Generic;
using System.Linq;

namespace ChooseBestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            // your code
            var myArr = new List<int>();
            var myHashset = new HashSet<int[]>();

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < ls.Count; j++)
                {
                    for (int l = 0; l < ls.Count; l++)
                    {
                        
                    }
                }
            }

            return 0;
        }
    }
}
