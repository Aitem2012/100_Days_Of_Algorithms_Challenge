using System;
using System.Collections.Generic;
using System.Linq;

namespace ReRot
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(RevRot("123456987654", 6));
        }
        public static string RevRot(string strng, int sz)
        {
            if (strng.Length <=0) return "";
            var myList = new List<string>();
            while (!(strng.Length < sz))
            {
                myList.Add(strng.Substring(0, sz));
                strng = strng.Remove(0, sz);
            }

            var myStr = "";
            foreach (var item in myList)
            {
                var multiplier = 1;
                foreach (var eachItem in item)
                {
                    multiplier *=(int) Math.Pow(Char.GetNumericValue(eachItem), 3);
                }
                if (multiplier % 2 == 0)
                {
                    myStr += item.Substring(1) + item.Substring(0,1);
                }
                else{
                    myStr += String.Join("", item.Reverse());
                    
                }
            }          

            return myStr;
        }
    }
}
