using System;

namespace ReversingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program to reverse a string \n");

            //Taking input
            Console.WriteLine("Enter a string to be reversed \n");
            string s = Console.ReadLine();

            //Reversing string
            int length = s.Length;
            //Console.WriteLine("Length of the string is: " + length);    
            string[] sarr = s.Split("-");
            Array.Reverse(sarr);
            for(int i=0;i<sarr.Length-1;i++)
            {
                Console.Write(sarr[i] + "-");
            }
            Console.Write(sarr[sarr.Length-1]);

        }
    }
}
