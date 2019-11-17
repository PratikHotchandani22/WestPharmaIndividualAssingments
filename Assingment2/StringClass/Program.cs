using System;

namespace StringClass
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool more = true;

            Console.WriteLine("C# progrma for String class and Sting functions");
            Console.WriteLine("Enter a string to perform operations");

            string s = Console.ReadLine();

            while(more)
            {

                Console.WriteLine("Enter 1 to perform conversion of string to upper case ");
                
                Console.WriteLine("Enter 2 to find length of string ");
                
                Console.WriteLine("Enter 3 to find index position of first occurence of character");
                
                Console.WriteLine("Enter 4 to check whether first character of string is same as specified value ");
                
                Console.WriteLine("Enter 5 to insert string or character at specified postion");
                
                Console.WriteLine("Enter 6 to check if string contains a specified char or string exist in it");
                
                Console.WriteLine("Enter 7 to remove characters from string to a specified position");

                Console.WriteLine("Enter 8 to convert string into char array ");
                
                Console.WriteLine("Enter 9 to check if string equals another string");
                
                Console.WriteLine("Enter 10 to replace a specified character with another character ");

                Console.WriteLine("Enter 11 to exit");

                char ch;
                int pos;
                string s2;
                int n = Convert.ToInt32(Console.ReadLine());

                switch(n)
                {
                    case 1:
    
                    Console.WriteLine("String in Upper case is: " + s.ToUpper() + "\n");
                    break;

                    case 2:
                    Console.WriteLine("Length of string is: " + s.Length + "\n");
                    break;
                    
                    case 3:
                    Console.WriteLine("enter char value");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("position is: " + s.IndexOf(ch) + "\n");
                    break;

                    case 4:
                    Console.WriteLine("enter char value");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Does it start with it? " + s.StartsWith(ch) + "\n");
                    break;
                    
                    case 5:
                    Console.WriteLine("Enter position");
                    pos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter char or string to be entered");
                    s2 = Console.ReadLine();
                    Console.WriteLine("updated string is: " + s.Insert(pos,s2) + "\n");
                    break;

                    case 6:
                    Console.WriteLine("enter char or string to be checked");
                    s2 = Console.ReadLine();
                    Console.WriteLine("Does it contains? " + s.Contains(s2) + "\n");
                    break;
                    
                    case 7:
                    Console.WriteLine("Enter position");
                    pos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("deleted part is: " + s.Remove(pos) + "\n");
                    break;

                    case 8:
                    char[] c2 = s.ToCharArray();
                    foreach(char x in c2)
                    {
                        Console.WriteLine(x);
                    } 
                    break;
                    
                    case 9:
                    Console.WriteLine("enter string to be compared");
                    s2 = Console.ReadLine();
                    Console.WriteLine("is it same? " + s.Equals(s2) + "\n");
                    break;

                    case 10:
                    Console.WriteLine("enter char value to be replaced");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("enter char to be replaced with");
                    char crepalced = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Updated string is: " + s.Replace(ch,crepalced) + "\n");
                    break;

                    case 11: 
                    Console.WriteLine("Exiting..");
                    more = false;
                    break;

                    default:
                    Console.WriteLine("not in range, choose between 1- 11");
                    break;
                }

        }

        }
    }
}
