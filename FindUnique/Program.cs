using System;
using System.Collections.Generic;
using System.Linq;

namespace FindUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new List<int> { 1, 1, 1, 2, 1, 1}));
        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            //your code
            var myDict = new Dictionary<int, int>();
            var uniqueNumbers = numbers.Distinct(); // myDict <1, 5> <2, 1>
            foreach (var item in uniqueNumbers)
            {
            var counter = 0;
                foreach (var num in numbers)
                {
                    if (item == num)
                    {
                        counter++;
                    }
                }
                myDict.Add(item, counter);
            }

            var different = myDict.Values.Min();
            foreach (var item in myDict)
            {
                if (item.Value == different)
                {
                    return item.Key;
                }
            }

            return 0;
        }
    }
}
