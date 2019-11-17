using System;

namespace CurrentDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n C# program to print Current date and time \n");

            DateTime dt =DateTime.Now;
            Console.WriteLine(dt + "\n");
        }
    }
}
