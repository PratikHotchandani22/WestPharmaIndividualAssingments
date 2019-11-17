using System;
using System.Collections.Generic;

namespace SortedStringCountDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program to Count the Simliar sorted strings in Dictionary");
            string[] sarr = {"ABC", "XYZ" ,"EFG" ,"WQE", "BCA" , "YZX" , "ACB"};
            

            Dictionary<string,int> dict = new Dictionary<string, int>();
            for(int i=0;i<sarr.Length;i++)
            {
                char[] c= sarr[i].ToCharArray();
                Array.Sort(c);
                string s  = new string(c);
                
                if(!dict.ContainsKey(s))
                {
                    dict.Add(s,1);
                    continue;
                }
                else
                {
                    dict[s] = dict[s] + 1;
                }
                 
            }
            //Console.WriteLine(dict);
            foreach(KeyValuePair<string,int> kv in dict)
            {
                Console.WriteLine(kv);
            }
        }
    }
}
